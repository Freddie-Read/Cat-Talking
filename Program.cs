string[] noises = { "meow", "hiss", "mew", "purr", "grr", "sss", "yowl", "mmmmm" };
string[] punc = { ".", "!", "...", "?" };

Random random = new Random();
int sentenceLength = random.Next(7, 23);
int paragraphLength = random.Next(5, 9);

string paragraph = "";

for (int i = 0; i < paragraphLength; i++)
{
    string sentence = "";
    for (int j = 0; j < sentenceLength; j++)
    {
        int noiseIndex = random.Next(0, 7);

        if (j == 0)
        {
            sentence += char.ToUpper(noises[noiseIndex][0]) + noises[noiseIndex].Substring(1) + " ";
        }
        else
        {
            sentence += noises[noiseIndex] + " ";
        }
    }
    sentenceLength = random.Next(13, 23);
    paragraph += sentence.Trim() + punc[random.Next(0, 3)] + " ";
}

Console.WriteLine(paragraph);