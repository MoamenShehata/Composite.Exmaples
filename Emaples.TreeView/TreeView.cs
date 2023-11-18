namespace Emaples.TreeView
{
	public static class TreeView
	{
		public static void Render(IEnumerable<INode> nodes)
		{
			foreach (INode node in nodes)
			{
				node.Render();
			}
		}
	}
}