namespace SimpleCLI;
public class Button
{
    //Variables + Defaults
    private string Text;
    public Button[] NextButtons;
    private static void NoMethod(){}
    public Delegate Method = NoMethod;
    
    //Declaring Methods
    public Button(string text)
    {
        Text = text;
    }
    
    public Button(string text, Delegate method)
    {
        Text = text;
        Method = method;
    }
    
    public Button(string text, Button[] nextButtons)
    {
        Text = text;
        NextButtons = nextButtons;
    }
    
    //Display Next Buttons
    public void Display(int index, ConsoleColor color = ConsoleColor.Red)
    {
        Console.CursorVisible = false;
        Console.Clear();
        for (int i = 0; i < NextButtons.Length; i++)
        {
            Button button = NextButtons[i];
            if (i == index)
            {
                var hold = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.WriteLine(button.Text);
                Console.ForegroundColor = hold;
                continue;
            }
            Console.WriteLine(button.Text);
        }
    }
}