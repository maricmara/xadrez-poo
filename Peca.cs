using System.ComponentModel.DataAnnotations;

public abstract class Peca{
    public int x, y;
    public string img = "";
    public PictureBox pictureBox = new PictureBox();
    public Peca(int x, int y, string img){
        
        this.x = x/50;
        this.y = y/50;

        pictureBox.Location = new Point(x , y);
        pictureBox.Size = new Size(50, 50); // O Tamanho é fixo
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        
        try{
            this.img = Path.Combine(Application.StartupPath, "imagens", img);
             pictureBox.Image = Image.FromFile(this.img); 
             
        }catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);  
        }

    }
    public abstract bool validarMovimento(int destinoX, int destinoY);

}