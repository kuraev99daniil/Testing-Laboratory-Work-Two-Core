namespace Laboratory_Work_Two_Core
{
    public class Params
    {
        public Params(double start, double end, double step)
        {
            Start = start;
            End = end;
            Step = step;
        }

        public double Start { get; set; }
        public double End { get; set; }
        public double Step { get; set; }
    }
}
