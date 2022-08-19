Console.Clear();
int ax = 30;
int ay = 0;
int bx = 0;
int by = 15;
int cx = 60;
int cy = 15;
int medx = 0;
int medy = 0;
int n = 0;
while (n < 5000)
{
    int rand = new Random().Next(0, 3);
    if (rand == 0)
    {
        medx = (ax+medx)/2;
        medy = (ay+medy)/2;
    }
    if (rand == 1)
    {
        medx = (bx+medx)/2;
        medy = (by+medy)/2;
    }
    if (rand == 2)
    {
        medx = (cx+medx)/2;
        medy = (cy+medy)/2;
    }

    Console.SetCursorPosition(medx,medy);
    Console.WriteLine("*");

    
    n = n + 1;

}
