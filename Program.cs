using SimpleCLI;

static void Print()
{
    Console.WriteLine("Yes");
}

Button alpha = new Button("a");
Button beta = new Button("b");
Button gama = new Button("c");
Button delta = new Button("d");

Button test1 = new Button("1", new []{alpha,beta,gama,delta});
Button test2 = new Button("2",Print);
Button head = new Button("Main", new []{test2, test1});

Displayer.Run(head);
