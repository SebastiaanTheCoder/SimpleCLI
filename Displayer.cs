namespace SimpleCLI;
public class Displayer
{
    public static void Run(Button startButton)
    {
        bool interfaceIsActive = true;
        int index = 0;
        Button activeButton = startButton;
        List<Button> previousButtons = new List<Button>();
        while (interfaceIsActive)
        {
            activeButton.Display(index);
            var keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.P:
                    interfaceIsActive = false;
                    break;
                case ConsoleKey.UpArrow:
                    index--;
                    break;
                case ConsoleKey.DownArrow:
                    index++;
                    break;
                case ConsoleKey.Enter:
                    if (activeButton.NextButtons[index].Method!= null)
                    {
                        activeButton.NextButtons[index].Method.DynamicInvoke();
                    }
                    if (activeButton.NextButtons[index].NextButtons != null)
                    {
                        previousButtons.Add(activeButton);
                        activeButton = activeButton.NextButtons[index];
                        index = 0;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    activeButton = previousButtons[^1];
                    previousButtons.Remove(activeButton);
                    index = 0;
                    break;
            }
            index = Math.Clamp(index, 0, activeButton.NextButtons.Length-1);
        }
    }
}