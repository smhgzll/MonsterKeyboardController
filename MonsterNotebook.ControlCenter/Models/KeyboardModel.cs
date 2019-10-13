namespace MonsterNotebook.ControlCenter.Models
{
    public class KeyboardModel
    {
        public object MqttID { get; set; }
        public string function { get; set; }
        public string mode { get; set; }
        public string effect { get; set; }
        public string light { get; set; }
        public string speed { get; set; }
        public string direction { get; set; }
        public string nv_save { get; set; }
        public Color color { get; set; }
        public int backgroundcolor { get; set; }
        public string alphabet { get; set; }
        public int solution { get; set; }
        public int level { get; set; }
        public int powerstatus { get; set; }
        public int type { get; set; }
    }
}
