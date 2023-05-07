namespace internet_shop_RazorPages;

public class Date : IDate
{
    public DayOfWeek GetDate()
    {
        return DateTime.Now.DayOfWeek;
    }
}