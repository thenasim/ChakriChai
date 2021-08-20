namespace BEL
{
    public class OkMsg
    {
        public string status = "OK";
        public string msg;

        public OkMsg(string msg)
        {
            this.msg = msg;
        }
    }
}