public class Rei : Peca{
    public Rei(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool validarMovimento(int destinoX, int destinoY)
    {
        // Calcula a diferença entre as posições
        int difX = Math.Abs(destinoX - x);
        int difY = Math.Abs(destinoY - y);

        // O Rei pode se mover apenas uma casa em qualquer direção
        return difX <= 1 && difY <= 1;
    }

}