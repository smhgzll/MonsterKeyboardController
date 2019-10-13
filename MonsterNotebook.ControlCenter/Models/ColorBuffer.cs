namespace MonsterNotebook.ControlCenter.Models
{
    public class ColorBuffer
    {
        public uint ID { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public ColorBuffer(int red, int green, int blue)
        {
            R = red;
            G = green;
            B = blue;
        }

        public ColorBuffer()
        {

        }
    }
}
