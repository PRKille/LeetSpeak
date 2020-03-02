namespace LeetSpeak1
{
  public class Translation
  {
    public char WordTranslate(char letter)
    {
      if (letter == 'e')
      {
        return '3';
      }
      else if (letter == 'o')
      {
        return '0';
      }
      else if (letter == 'L' || letter == 'I')
      {
        return '1';
      }
      else if (letter == 't')
      {
        return '7';
      }
      else if (letter == 's')
      {
        return 'z';
      }
      else
      {
        return letter;
      }
    }

    public char[] SentenceBreak(string Sentence)
    {
      char[] letters = Sentence.ToCharArray();
      return letters;
    }

    public string SentenceTranslate(char[] charArray)
    {
      for(int i = 0; i < charArray.Length; i++)
      {
        if(charArray[0] == 's')
        {
          i++;
        }
        if(charArray[i] == ' ' && charArray[i+1] == 's')
        {
          i+=2;
        }
        else
        {
          charArray[i] = WordTranslate(charArray[i]);
        }
      }
      return string.Join("", charArray);
    }
  }
}