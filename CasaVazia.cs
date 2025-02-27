
public class CasaVazia : Peca{
    public  CasaVazia(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool validarMovimento(int destinoX, int destinoY){
        return true;
    }

}