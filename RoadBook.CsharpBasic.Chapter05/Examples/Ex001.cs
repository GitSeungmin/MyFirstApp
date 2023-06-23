using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    internal class Ex001
    {
        public void Run()
        {
            Car001 car = new Car001(); //Car001 클래스의 car 객체 생성
            car.setSize("세단");  //Size라는 매개변수. set으로 시작하는 메소드이므로 setter 메소드. 캡슐화의 방식. car.size x, car.setSize o
            car.setColor("하얀"); //Color라는 매개변수

            Console.WriteLine("고객님의 차, {0} {1}이...", car.getColor(), car.getSize());

            car.Engine_on();
            car.Go();
            car.Back();
            car.Left();
            car.Right();
            car.Engine_off();
        }
    }

    class Car001    //Car001 클래스 생성
    {
        #region 형태
        private string size; //private로 선언하면 다른 클래스에서 호출 불가. 직접 값을 할당 불가. setSize라는 메소드로 값 할당 가능
        private string color;

        public void setSize(string size)
        {
            this.size = size;   //this: 객체 형태에 주어진 변수임. 객체의 변수인지 메소드의 매개변수인지 구분하게 함. 필수는 x
        }
        public string getSize()
        {
            return size;
        }

        public void setColor(string color)  //string형 변수
        {
            this.color = color;
        }
        public string getColor()
        {
            return color;
        }

        #region 행동
        public void Engine_on()
        {
            Console.WriteLine("시동을 켭니다.");
        }

        public void Engine_off()
        {
            Console.WriteLine("시동을 끕니다.");
        }

        public void Go()
        {
            Console.WriteLine("전진합니다.");
        }

        public void Back()
        {
            Console.WriteLine("후진합니다.");
        }

        public void Left()
        {
            Console.WriteLine("좌회전합니다.");
        }

        public void Right()
        {
            Console.WriteLine("우회전합니다.");
        }
        #endregion

    }
    #endregion
}