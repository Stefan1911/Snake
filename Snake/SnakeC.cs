using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    enum Direction { left,right,up,donw }
    class SnakeC
    {
        private Button head;
        private Button tail;

        private int moveInterval;
        private Direction dir;
        


        //konstruktor
        public SnakeC()
        {
            this.head = this.tail = Program.formPointer.HeadBt;
            this.moveInterval = head.Width;
            this.dir = Direction.right;
        }

        internal Direction Dir { get => dir; set => dir = value; }

        //Public Metodes
        public bool move(Direction dir)
        {
            switch (dir)
            {
                case Direction.up:
                    this.head.Location = new System.Drawing.Point(this.head.Location.X, this.head.Location.Y -this.moveInterval);
                    break;
                case Direction.donw:
                    this.head.Location = new System.Drawing.Point(this.head.Location.X, this.head.Location.Y + this.moveInterval);
                    break;
                case Direction.right:
                    this.head.Location = new System.Drawing.Point(this.head.Location.X+ this.moveInterval, this.head.Location.Y);
                    break;
                case Direction.left:
                    this.head.Location = new System.Drawing.Point(this.head.Location.X - this.moveInterval, this.head.Location.Y);
                    break;
            }
            return true;
        }
    }
}
