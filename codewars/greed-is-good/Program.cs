int[] dice = [2, 2, 2, 3, 1];

int score = 0;

int[] counts = new int[7];

foreach (int num in dice)
{
    counts[num]++;
}

for (int i = 2; i <= 6; i++)
{
    if (counts[i] >= 3)
    {
        score = i * 100;
    }
}

if (counts[1] >= 3)
{
    score = 1000;
}


int remainingOnes = counts[1] >= 3 ? counts[1] - 3 : counts[1];
int remainingFives = counts[5] >= 3 ? counts[5] - 3 : counts[5];

score += remainingOnes * 100;
score += remainingFives * 50;

Console.WriteLine(score);