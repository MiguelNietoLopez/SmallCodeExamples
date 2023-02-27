// Reverses words in the same order they were written. EX: The quick brown fox jumps over the lazy dog -> ehT kciuq nworb xof spmuj revo eht yzal god

string inputString = "The quick brown fox jumps over the lazy dog";
string[] inputArray = inputString.Split(" ");
string inputReversed = "";
foreach (string word in inputArray)
{
    char[] temp = word.ToCharArray();
    Array.Reverse(temp);
    inputReversed += String.Join("",temp) + " ";

}
Console.WriteLine(inputReversed);
