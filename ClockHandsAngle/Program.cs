namespace ClockHandsAngle
{
    public class Program
    {
        public static double calculateAngle(int hours, double minutes)
        {
            if (hours == 12)
            {
                hours = 0;
            }

            if (minutes == 60)
            {
                minutes = 0;
            }

            double adjustedHour = hours + minutes / 12 / 60; //adjusting for minutes
            double hourAngle = adjustedHour * 360 / 12;
            double minuteAngle = minutes * 360 / 60;
            double angle;

            if (hourAngle > minuteAngle)
            {
                angle = hourAngle - minuteAngle;
            }
            else
            {
                angle = minuteAngle - hourAngle;
            }
            if (angle > 180)
            {
                angle = 360 - angle;
            }
            return (Math.Round(angle, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input hours in 12hour format:");
            string hoursString = Console.ReadLine();
            int hours = Int32.Parse(hoursString);
            if (hours > 12 || hours < 0)
            {
                Console.WriteLine("Hour format is not valid");
                return;
            }


            Console.WriteLine("Please input minutes:");
            string minutesString = Console.ReadLine();
            double minutes = Double.Parse(minutesString);
            if (minutes > 60 || minutes < 0)
            {
                Console.WriteLine("Minute format is not valid");
                return;

            }
            //var calculateAngle = new CalculateAngle();
            double angle = calculateAngle(hours, minutes);

            Console.WriteLine($"Angle between hands is {angle} degrees");
        }
    }
}