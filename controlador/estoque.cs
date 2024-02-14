using jogaOnline.Prodduct;
using System.Collections;
using System.IO;

namespace jogaOnline.controlador{

    class Estoque{

        public Dictionary<ProductGeneric, int> QtdEstoque = new Dictionary<ProductGeneric, int>();


    
        public void  AlterarEstoque(ProductGeneric novoProduto, int quantidade){

             if(Verificar(novoProduto)){
                Console.WriteLine("produto já existe, atalizando a quantidade");
                QtdEstoque[novoProduto] += quantidade;
            }

            else{

                Console.WriteLine("produto cadastrado");
                QtdEstoque.Add(novoProduto,quantidade);

            }
                

            }

        


        public void remover(ProductGeneric novoProduto, int quantidade){

            if(Verificar(novoProduto)){
                int value = VerificaValor(novoProduto);

                if(value == 0 || quantidade > value){
                    Console.WriteLine("indisponivel");
                }
                else{
                    
                     QtdEstoque[novoProduto] -= quantidade;
                }
            }
        }
            
        
        public int VerificaValor(ProductGeneric novo){
            int value;
            QtdEstoque.TryGetValue(novo, out value);
            return value;

        }
        public bool Verificar(ProductGeneric novoProduto){
           
            return QtdEstoque.ContainsKey(novoProduto);

        }
    }}

