namespace Models
{
    public class Watch
    {
        public bool Status { get; set; }

        private DateTime StartTime { get; set; }
        private DateTime StopTime { get; set; }

        public Watch()
        {
            Status = false; 
        }

        public bool Start()
        {
            if (Status)
            {
                Console.WriteLine("Stopwatch is already Started");
                return false;
            }

            Status = true;
            StartTime = DateTime.Now;

            Console.WriteLine($"Stop Watch Started at {StartTime}");
            return true;
        }


        public bool Stop()
        {
            if (!Status)
            {
                Console.WriteLine("Stopwatch is already Stopped");
                return false;
            }

            Status = false;
            StopTime = DateTime.Now;
            Console.WriteLine($"Stop Watch Started at {StartTime}");
            Console.WriteLine($"Stop Watch Stopped  at {StopTime}");
            Console.WriteLine($"Total Time taken is {StopTime - StartTime}");

            return true;
        }
    }
}