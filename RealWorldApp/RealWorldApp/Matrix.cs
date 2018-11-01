using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealWorldApp
{
    class Matrix
    {
        private Personage[,] board;
        private Queue<Personage> queue;
        private int n;
        private String text;
        private int kills;
        private int resurrections;
        private int cola;
        

        public Matrix(int n)
        {
            this.n = n;
            this.board = new Personage[n, n];
            this.queue = new Queue<Personage>();
            
            for(int i = 0; i < 200; i++)
            {
                Personage p = new Personage();
                queue.Enqueue(p);
            }
            this.kills = 0;
            this.resurrections = 0;
            this.cola = 0;
            putNeoSmith();
            putPersonages();
        }

        public void putNeoSmith()
        {
            Neo neo = new Neo();
            Smith smith = new Smith();
            int row = Useful.random_Number(0, n);
            int col = Useful.random_Number(0, n);
            if(board[row,col] == null)
            {
                board[row, col]= neo;
            }
            bool salir = false;
            do
            {
                row = Useful.random_Number(0, n);
                col = Useful.random_Number(0, n);
                if (board[row, col] == null)
                {
                    board[row, col] = smith;
                    salir = true;
                }
            } while (!salir);
            
        }

        public void putPersonages()
        {
            int row, col;
            for(int i = 0; i < n * n; i++)
            {
                row = i / n;
                col = i % n;
                if (board[row, col] == null)
                {
                    Personage p = queue.Dequeue();
                    this.cola++;
                    board[row, col] = p;
                }
            }
        }

        public Personage[,] getBoard()
        {
            return this.board;
        }


        public void evaluatePercentages()
        {
            int row, col;
            for (int i = 0; i < n * n; i++)
            {
                row = i / n;
                col = i % n;
                if (board[row, col] != null &&
                    (!(board[row, col] is Neo) && !(board[row, col] is Smith)))
                {
                    if(board[row,col].getPercentageDie() > 70)
                    {
                        if (queue.Count() > 0)
                        {
                            board[row, col] = queue.Dequeue();
                            this.cola++;
                        }
                        else
                        {
                            board[row, col] = null;
                        }
                        
                    }
                    else
                    {
                        board[row, col].incrementPercentage();
                    }
                }
            }
        }
        

        public void actionSmith(RichTextBox richText, Label lblMuertes)
        {
            List<Cell> pathOpt;
            List<Cell> path;
            bool[,] visited;
            pathOpt = new List<Cell>();
            path = new List<Cell>();
            visited = new bool[n, n];
            Cell cs = whereIsSmith();
            Cell cn = whereIsNeo();
            smithAction(cs, cn, path, ref pathOpt, visited);
            //Console.WriteLine(pathOpt.Count);
            /*foreach(Cell c in pathOpt)
            {
                Console.WriteLine(c.getX()+" "+c.getY());
            }*/
            Cell c2 = whereIsSmith();
            Smith s = (Smith)board[c2.getX(), c2.getY()];
            s.setInfect(pathOpt.Count);
            smithKill(pathOpt, s.getInfect(),lblMuertes);
            this.text += "Smith infect: " + s.getInfect() + "\n";
            richText.Text = text;
            /*Console.WriteLine("Infect: "+s.getInfect() +" - Fin acción Smith");
            Console.WriteLine("===================================================================================");
            print();
            Console.WriteLine("===================================================================================");*/
        }

        public void smithKill(List<Cell> pathOpt, int infect, Label lblMuertes)
        {
            for(int i = 0, cont=0; i < pathOpt.Count - 1 && cont<infect;i++)
            {
                Cell c = pathOpt[i];
                if (this.board[c.getX(), c.getY()] != null)
                {
                    board[c.getX(), c.getY()].setPercentage(100);
                    board[c.getX(), c.getY()] = null;
                    cont++;
                    kills++;
                }
                lblMuertes.Text = kills+"";
            }
        }
        
        
        public void smithAction(Cell cS, Cell cN, List<Cell> path,ref List<Cell> pathOpt, bool[,] visited)
        {
            if (cS.Equals(cN))
            {
                if (path.Count < pathOpt.Count || pathOpt.Count==0)
                {
                    pathOpt = path.GetRange(0, path.Count);
                }
            }
            else
            {
                for(int i = -1; i <= 1; i++)
                {
                    for(int j = -1; j <= 1; j++)
                    {
                        if(Math.Abs(i)+Math.Abs(j)==1)
                        {
                            Cell aux = new Cell(cS.getX()+i, cS.getY()+j);
                            if (isInside(aux))
                            {
                                if (!isVisited(aux,visited))
                                {
                                    visited[cS.getX(), cS.getY()] = true;
                                    path.Add(aux);
                                    smithAction(aux, cN, path, ref pathOpt, visited);
                                    //Zona deshacer
                                    removeVisited(aux,visited);
                                    path.RemoveAt(path.Count-1);
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool isInside(Cell c)
        {
            if(c.getX()<0 || c.getY()<0 || c.getX()>=this.n || c.getY() >= this.n)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isVisited(Cell c, bool[,] visited)
        {
            return visited[c.getX(), c.getY()];
            
        }

        public void removeVisited(Cell c, bool[,] visited)
        {
            visited[c.getX(), c.getY()]=false;
        }


       
        public void swapNeo(RichTextBox richText){
            int row, col;
            Cell c = whereIsNeo();
            row = Useful.random_Number(0, n);
            col = Useful.random_Number(0, n);
            Personage p = board[row, col];
            board[row, col] = board[c.getX(), c.getY()];
            board[c.getX(), c.getY()] = p;
            this.text += "Neo's position has changed \n";
            richText.Text = text;
            //Console.WriteLine("Neo cambia de posición");
        }
        public void neoAction(RichTextBox richText, Label lblRes)
        {
            Cell c=whereIsNeo();
            Neo neo = board[c.getX(), c.getY()] as Neo;
            neo.setBeliever();
            if (neo.isBeliever())
            {
                this.text+="Neo is believer \n";
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        Cell aux = new Cell(c.getX() + i, c.getY() + j);
                        if (isInside(aux))
                        {
                            if (board[aux.getX(), aux.getY()] == null)
                            {
                                if (queue.Count > 0)
                                {
                                    board[aux.getX(), aux.getY()] = queue.Dequeue();
                                    this.cola++;
                                    this.resurrections++;
                                }
                            }
                        }
                    }
                }
                lblRes.Text = this.resurrections + "";
                
                /*Console.WriteLine("Fin acción Neo");
                Console.WriteLine("===================================================================================");
                print();
                Console.WriteLine("===================================================================================");*/
            }
            else
            {
                this.text+= "Neo is not believer \n";
                richText.Text = text;
                //Console.WriteLine("Neo no es el elegido");
            }


        }

       

        /*public void print()
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(board[i,j] is Neo)
                    {
                        Console.Write("N        \t");
                    }
                    else if(board[i,j] is Smith)
                    {
                        Console.Write("S        \t");
                    }
                    else if (board[i, j] == null)
                    {
                        Console.Write("Null     \t");
                    }
                    else
                    {
                        Console.Write(board[i, j].getName() + "\t");
                    }
                    
                }
                Console.WriteLine("");
            }
        }*/


        public Cell whereIsNeo()
        {
            int row, col, rowN = 0, colN = 0;
            for (int i = 0; i < this.n * this.n; i++)
            {
                row = i / this.n;
                col = i % this.n;

                if (board[row, col] is Neo)
                {
                    rowN = row;
                    colN = col;
                }
            }
            Cell c = new Cell(rowN, colN);
            return c;
        }

        public Cell whereIsSmith()
        {
            Cell c=null;
            int row, col;
            for (int i = 0; i < this.n * this.n; i++)
            {
                row = i / this.n;
                col = i % this.n;

                if (board[row, col] is Smith)
                {
                    c = new Cell(row,col);
                }
            }
            return c;
        }

        public bool isEnd()
        {
            bool end = false;
            int row, col, cont=0;
            for (int i = 0; i < this.n * this.n; i++)
            {
                row = i / this.n;
                col = i % this.n;

                if (!(board[row, col] is Neo) && !(board[row, col] is Smith) && board[row, col]!=null)
                {
                    cont++;
                }
            }
            if (cont == 0)
            {
                end = true;
            }
            return end;
        }

        public int update(DataGridView dgv)
        {
            Cell cN = whereIsNeo();
            Cell cS = whereIsSmith();
           // dgv.Rows[cN.getX()].Cells[cN.getY()].Style.BackColor = System.Drawing.Color.BlueViolet;
            dgv.Rows[cN.getX()].Cells[cN.getY()].Value = Image.FromFile("..\\..\\neo.png");

            dgv.Rows[cS.getX()].Cells[cS.getY()].Style.BackColor = System.Drawing.Color.LightSkyBlue;
            dgv.Rows[cS.getX()].Cells[cS.getY()].Value = Image.FromFile("..\\..\\smith.png");
            int row, col;
            for (int i = 0; i < this.n * this.n; i++)
            {
                row = i / this.n;
                col = i % this.n;

                if (!(board[row, col] is Neo) && !(board[row, col] is Smith) && board[row, col] != null)
                {
                    Personage p = board[row, col];
                    int die = p.getPercentageDie();
                    dgv.Rows[row].Cells[col].Value = Image.FromFile("..\\..\\genericos.png");
                    /*if (die <= 10)
                    {
                        dgv.Rows[row].Cells[col].Style.BackColor = System.Drawing.Color.FromArgb(245, 177, 189);
                    }
                    else if (die > 10 && die <= 20)
                    {
                        dgv.Rows[row].Cells[col].Style.BackColor = System.Drawing.Color.FromArgb(235, 86, 113);
                    }
                    else if (die > 20 && die <= 30)
                    {
                        dgv.Rows[row].Cells[col].Style.BackColor = System.Drawing.Color.FromArgb(230, 38, 72);
                    }
                    else if (die > 30 && die <= 40)
                    {
                        dgv.Rows[row].Cells[col].Style.BackColor = System.Drawing.Color.FromArgb(233, 189, 51);
                    }
                    else if (die > 40 && die <= 50)
                    {
                        dgv.Rows[row].Cells[col].Style.BackColor = System.Drawing.Color.FromArgb(148, 18, 40);
                    }
                    else if (die > 50 && die <= 60)
                    {
                        dgv.Rows[row].Cells[col].Style.BackColor = System.Drawing.Color.FromArgb(108, 13, 30);
                    }
                    else if (die > 60 && die <= 70)
                    {
                        dgv.Rows[row].Cells[col].Style.BackColor = System.Drawing.Color.FromArgb(77, 9, 20);
                    }
                    else
                    {
                        dgv.Rows[row].Cells[col].Style.BackColor = System.Drawing.Color.FromArgb(38, 4, 11);
                    }*/
                }
                if (board[row, col] == null)
                {
                    dgv.Rows[row].Cells[col].Value = Image.FromFile("..\\..\\muertes.png");
                }

               
            }
            return cola;
        }


    }
}
