namespace Bookify.Domain.Bookings;

public record DateRange
{
    private DateRange()
    {
    }

    public DateOnly Start { get; init; }

    public DateOnly End { get; init; }

    public int LeengthInDays => End.DayNumber - Start.DayNumber;

    public static DateRange Create(DateOnly start, DateOnly end)
    {
        if (start > end)
        {
            throw new ApplicationException("End date precedes starts date");
        }

        return new DateRange
        {
            Start = start,
            End = end
        };
    }
}