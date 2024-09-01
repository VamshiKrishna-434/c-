Console.WriteLine("enter the size");
int n = Console.Read();
int[] nums = new int[n];// { 2,-5,2,7,0};
float A =0, B=0, C=0;
Console.WriteLine("ENTER THE test cases");
for(int i = 0; i < n; i++)
{
    nums[i]= Console.Read();
}
foreach(int a in nums)
{
    if (a > 0)
    {A++;}
    else if (a < 0)
    {B++;}
    else {C++;}
}
Console.WriteLine("the plus ratio is "+A/5);
Console.WriteLine("the minus ratio is "+ B/ 5);
Console.WriteLine("the 0 ratio is " + C/5);