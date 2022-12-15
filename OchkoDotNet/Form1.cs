namespace OchkoDotNet
{
    public partial class Form1 : Form
    {
        List<String> begemoti = new List<string>();
        uint count = 0;

        public Form1()
        {
            InitializeComponent();
            begemoti.Add("http://prazhak.ru/wp-content/uploads/2011/07/IMG_1737.jpg");
            begemoti.Add("https://www.nastol.com.ua/download.php?img=202201/2560x1440/nastol.com.ua-484370.jpg");
            begemoti.Add("https://i.pinimg.com/originals/08/90/36/089036ef657c7fe5aa8c2e5e030db0e2.jpg");
            begemoti.Add("https://a.d-cd.net/ThLO0i4pta37q9aK-t0PUGsYneU-960.jpg");
            begemoti.Add("https://st.depositphotos.com/2193402/4543/i/950/depositphotos_45432245-stock-photo-hippopotamus.jpg");
            begemoti.Add("https://cs5.pikabu.ru/post_img/big/2014/03/27/10/1395936763_2033211532.jpg");
            begemoti.Add("https://s00.yaplakal.com/pics/pics_original/0/9/2/11986290.jpg");
            begemoti.Add("https://www.pvsm.ru/images/2022/01/19/pogromist-moi-samye-epichnye-provaly-za-vsyu-kareru.jpeg");
        }

        private void btn_Click(object sender, EventArgs e)
        {
                Form2 form2 = new Form2();
                form2.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            nosorog2Pic.ImageLocation = begemoti[Convert.ToInt32(count) % begemoti.Count];
            nosorogPic.ImageLocation = begemoti[(Convert.ToInt32(count) + 4) % begemoti.Count];
            count++;
        }
    }
}
