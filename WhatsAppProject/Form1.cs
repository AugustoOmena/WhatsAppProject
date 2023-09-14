namespace WhatsAppProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WhatsAppSendMessage w = new WhatsAppSendMessage();
            //w.SendMessage("Hello World", "24981021079");
            w.SendMessageGroup("Hello World", "24981021079");
            //w.SendMessageWithImage("Hello World", "\"C:\\Users\\guguo\\Desktop\\CONVOCACAO\\EDITAL DE CONVOCAÇÃO Robotica.pdf\"", "24981021079");
        }
    }
}