 416. Partition Equal Subset Sum + shortName);

Partition partition = new Partition(); int[] nums = { 1, 5, 11, 5 }; if(partition. CanPartition (nums))

Console.WriteLine("true");|||

} else

{

Console.WriteLine("false");

}
//main up
public  class Partition 
{
public bool CanPartition(int[] mans)
{
int sum nums. Sun();

if (suum & 2= 1)
{
return false;
}
int needsun sun / 2; bool dp new boolfneedsum+13;

do[0] = true;

foreach (int nun in nums) 14 (1> nun)
{
for (int i= needsun; i > 0; i--)
{
if(i>= num)
{
dp[i] = dp[i] || Ex-num];
}
}
}
return dp[needsum];
}
}
