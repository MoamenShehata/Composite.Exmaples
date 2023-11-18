namespace Emaples.TreeView
{
	public interface INode
	{
		void Render();
		INode Parent { get; set; }
	}

	public class LeafNode : INode
	{
		private readonly string name;
		public LeafNode(string name)
		{
			this.name = name;
		}

		public INode Parent { get; set; }

		public void Render()
		{
			Console.WriteLine($" {name}");
		}
	}

	public class CompositeNode : INode
	{
		private readonly IList<INode> nodes = new List<INode>();
		private readonly string name;

		public CompositeNode(string name)
		{
			this.name = name;
		}

		public INode Parent { get; set; } = null!;

		public void Add(INode node)
		{
			node.Parent = this;
			nodes.Add(node);
		}
		public void Remove(INode node)
		{
			nodes.Remove(node);
		}

		public void Render()
		{
			Console.WriteLine($"-{name}");
			foreach (var node in nodes)
			{
				RenderTabs(node);
				node.Render();
			}
		}

		private void RenderTabs(INode node)
		{
			var parent = node.Parent;
			while (parent != null)
			{
				Console.Write("\t");
				parent = parent.Parent;
			}
		}
	}
}