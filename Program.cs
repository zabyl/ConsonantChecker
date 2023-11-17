internal class Program
{
    private static void Main(string[] args)
    {
        CheckConsonantOrder();
    }

    static void CheckConsonantOrder()
    {
      Console.WriteLine("Please write a sentence to check its consonant order: ");
      string input = Console.ReadLine();

      if (String.IsNullOrEmpty(input))
      {
          Console.WriteLine("Please write something!");
      }
      else
      {
        string lowered = input.ToLower();
        string[] words = lowered.Split(" ");
        string vowels = "aeıioöuü";
        string result = "";
        bool[] check = new bool[words.Length];
        int line = 0;
        foreach (var word in words)
        {
          int counter = 0;
          
          foreach (var character in word)
          {
              if (vowels.Contains(character))
              {
                  counter = 0;
              }
              else 
              {
                  counter++;
                  if (counter == 2)
                  {
                      check[line] = true;
                      break;
                  }
              }
          }
          line++;
        }
      
        foreach (var item in check)
        {
          result += item + " ";
        }
      
        Console.WriteLine(result);
        }
      
    }

}