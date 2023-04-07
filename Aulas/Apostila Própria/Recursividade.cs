using System;
public class Fat{
        public int fat(int n){
        if(n==0){
            return 1;
        }else{
            return n*fat(n-1);
        }

    }

}
public class Naturais{
    public ulong N(ulong n){
        if(n==0){
            return 0;
        }else {
            return n+N(n-1);
        }
    }
}
public class Strings
    {
        char[] palavra = new char[5];
        int K= palavra.Length;
        char[] invertida = new char[K-1];

        public char inverte(char[] invertida, char[] palavra,int K){
            if(K==0){
            return palavra[K-1];
            }else{ invertida[K-1] = palavra[K-(K-1)];  
                return inverte(invertida[K-1],palavra[K-(K-1)],K-1);

            }
        }

    }

public class Apostila{
    static void Main(){
        //Fat Fatorial = new Fat();
        //Console.WriteLine(Fatorial.fat(10));
        //Naturais natural = new Naturais();
        //Console.WriteLine(natural.N(100000));
        string U = "carro";
        char[] v = U.ToCharArray();
        char[] troquei = new char[v.Length];
      Strings comp = new Strings();
      comp.inverte(v,troquei,v.Length);
  

    }
}
