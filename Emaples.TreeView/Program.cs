// See https://aka.ms/new-console-template for more information
using Emaples.TreeView;

var directories = new List<INode>()
{
	new LeafNode("Desktop"),
};

var programData = new CompositeNode("ProgramData");
programData.Add(new LeafNode("Microsoft"));
programData.Add(new LeafNode("Intel"));
var users = new LeafNode("Users");
var cDrive = new CompositeNode("C://");
cDrive.Add(programData);
cDrive.Add(users);

var movies = new LeafNode("Movies");
var music = new LeafNode("Music");
var dDrive = new CompositeNode("D://");
dDrive.Add(movies);
dDrive.Add(music);


directories.Add(cDrive);
directories.Add(dDrive);

TreeView.Render(directories);
Console.ReadLine();
