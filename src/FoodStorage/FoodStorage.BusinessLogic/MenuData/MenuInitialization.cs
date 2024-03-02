using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using UnitsNet;
using UnitsNet.Units;

namespace PseudoMenu.MenuData
{


    internal class MenuInitialization
    {


        MenuCollection menuCollection = new MenuCollection();



        internal MenuInitialization()
        {
           

         Dish dish1 = new Dish("������ �������", "�������"); // �������
            dish1.AddProduct(new Product() { name = "���� ������� ����", quantity = Mass.FromGrams(600) }); 
            dish1.AddProduct(new Product() { name = "���� �������", quantity = Mass.FromKilograms(1) }); ;
            dish1.AddProduct(new Product() { name = "���� ��������", quantity = Mass.FromKilograms(0.5) }); ;
            dish1.AddProduct(new Product() { name = "���� ��������", quantity = Mass.FromKilograms(0.5) }); ;
            dish1.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(5) }); ;
            dish1.AddProduct(new Product() { name = "����� ������� �������", quantity = Mass.FromGrams(5) }); ;

            Dish dish2 = new Dish("������ �������", "�������"); // �������
            dish2.AddProduct(new Product() { name = "���� ��������", quantity = Mass.FromGrams(500) }); ;
            dish2.AddProduct(new Product() { name = "���� �������", quantity = Mass.FromGrams(500) }); ;
            dish2.AddProduct(new Product() { name = "���� ����� ����", quantity = Mass.FromGrams(500) }); ;
            dish2.AddProduct(new Product() { name = "������� ������", quantity = Mass.FromGrams(100) });
        
            dish2.AddProduct(new Product() { name = "��� �������� ������", quantity = Mass.FromGrams(100) }); 
            dish2.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(10) }); ;
            dish2.AddProduct(new Product() { name = "������ ��� ����", quantity = Mass.FromGrams(10) }); 
            dish2.AddProduct(new Product() { name = "����� ������� �������", quantity = Mass.FromGrams(5) }); 
            dish2.AddProduct(new Product() { name = "�������� ����", quantity = Mass.FromGrams(5) }); 


            Dish dish3 = new Dish("����� ������", "������"); // �����
            dish3.AddProduct(new Product() { name = "������� �������", quantity = Mass.FromGrams(300) }); 
            dish3.AddProduct(new Product() { name = "������� ����������������", quantity = Mass.FromGrams(200) });
            dish3.AddProduct(new Product() { name = "���� �������", quantity = Scalar.FromAmount(4) }); 
            dish3.AddProduct(new Product() { name = "��������� ������", quantity = Mass.FromGrams(200) }); 
            dish3.AddProduct(new Product() { name = "������ ����������������", quantity = Mass.FromGrams(200) }); 
            dish3.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(5) }); ;
            dish3.AddProduct(new Product() { name = "����� ������ �������", quantity = Mass.FromGrams(5) }); 

            Dish dish4 = new Dish("����� ���������", "������"); // �����
            dish4.AddProduct(new Product() { name = "������ ������", quantity = Mass.FromGrams(100) }); 
            dish4.AddProduct(new Product() { name = "������� ������", quantity = Mass.FromGrams(200) }); 
            dish4.AddProduct(new Product() { name = "����� ���������� ������", quantity = Mass.FromGrams(100) }); 
            dish4.AddProduct(new Product() { name = "������� ����������������", quantity = Mass.FromGrams(20) }); 
            dish4.AddProduct(new Product() { name = "��� �������� ������", quantity = Mass.FromGrams(100) }); 
            dish4.AddProduct(new Product() { name = "��� ����", quantity = Mass.FromGrams(100) }); ;
            dish4.AddProduct(new Product() { name = "�������� ������", quantity = Mass.FromGrams(10) }); 
            dish4.AddProduct(new Product() { name = "������ ����������� �����", quantity = Mass.FromGrams(10) }); 
            
            dish4.AddProduct(new Product() { name = "����� ���������", quantity = Volume.FromMilliliters(10) }); 

            Dish dish5 = new Dish("����� ������", "������"); // �����
            dish5.AddProduct(new Product() { name = "������ ������ ������� ������", quantity = Mass.FromGrams(30) }); 
            dish5.AddProduct(new Product() { name = "����� ������", quantity = Mass.FromGrams(100) }); 
            dish5.AddProduct(new Product() { name = "��� ��������", quantity = Mass.FromGrams(100) });
            dish5.AddProduct(new Product() { name = "���� ������� ������", quantity = Mass.FromGrams(400) });
            dish5.AddProduct(new Product() { name = "���� �������", quantity = Scalar.FromAmount(2) });
            dish5.AddProduct(new Product() { name = "����� ���������", quantity = Volume.FromMilliliters(10) });
            dish5.AddProduct(new Product() { name = "������ ������", quantity = Mass.FromGrams(20) }); 
            dish5.AddProduct(new Product() { name = "������� ����", quantity = Mass.FromGrams(20) }); 
            dish5.AddProduct(new Product() { name = "������� ������ ������", quantity = Mass.FromGrams(100) } ); 
            dish5.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(10) }); ;

            Dish dish6 = new Dish("������� ������", "������� �����"); // ������� �����
            dish6.AddProduct(new Product() { name = "���� �������", quantity = Mass.FromKilograms(2) } ); 
            dish6.AddProduct(new Product() { name = "���� ������", quantity = Mass.FromGrams(15) } ); 
            dish6.AddProduct(new Product() { name = "���� �������", quantity = Mass.FromGrams(20) } ); 
            dish6.AddProduct(new Product() { name = "��� �������� ������", quantity = Mass.FromGrams(100) }); 
            dish6.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(5) }); 

            Dish dish7 = new Dish("������� ������", "������� �����"); // ������� �����
            dish7.AddProduct(new Product() { name = "���� ������� ����", quantity = Mass.FromKilograms(1) }); //1 ��
            dish7.AddProduct(new Product() { name = "��� �������� ������", quantity = Mass.FromGrams(200) }); // 2 ��.
            dish7.AddProduct(new Product() { name = "���� �������", quantity = Volume.FromMilliliters(150) }); // 150 ��.
            dish7.AddProduct(new Product() { name = "������ ��� ������", quantity = Mass.FromGrams(10) }); // 10- ��
            dish7.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(10) }); // 10 ��
            dish7.AddProduct(new Product() { name = "����� ������ �������", quantity = Mass.FromGrams(10) }); // 10 ��
            dish7.AddProduct(new Product() { name = "����� ������", quantity = Mass.FromGrams(100) }); // 1 ��.
            dish7.AddProduct(new Product() { name = "����� ������������", quantity = Volume.FromMilliliters(100) }); // 1 ��.

            Dish dish8 = new Dish("������ � �������", "������� �����"); // ������� �����
            dish8.AddProduct(new Product() { name = "��������� ������", quantity = Mass.FromKilograms(1) }); // 1 ��
            dish8.AddProduct(new Product() { name = "������� ������", quantity = Mass.FromGrams(100) }); // 2 ��.
            dish8.AddProduct(new Product() { name = "����� ����������", quantity = Mass.FromGrams(400) }); // 400 �
            dish8.AddProduct(new Product() { name = "������� ����������������", quantity = Mass.FromGrams(250) }); //250 �.
            dish8.AddProduct(new Product() { name = "����� ������������", quantity = Volume.FromMilliliters(100) }); // 6 �����
            dish8.AddProduct(new Product() { name = "���� ������", quantity = Volume.FromMilliliters(100) }); // 4 �����
            dish8.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(10) }); // 10 �.
            dish8.AddProduct(new Product() { name = "����� ������� �������", quantity = Mass.FromGrams(10) }); // 10 �.
         




            Dish dish9 = new Dish("������ �����", "������� �����"); // ������� �����
            dish9.AddProduct(new Product() { name = "���� ������� �������", quantity = Mass.FromGrams(450) }); // 450 �
            dish9.AddProduct(new Product() { name = "��� �������", quantity = Mass.FromGrams(60) }); // 60 �.
            dish9.AddProduct(new Product() { name = "������� ������", quantity = Mass.FromGrams(150) }); // 1 ��.
            dish9.AddProduct(new Product() { name = "��� �������� ������", quantity = Mass.FromGrams(100) }); // 1 ��.
            dish9.AddProduct(new Product() { name = "����� ������������", quantity = Volume.FromMilliliters(20) }); // 2 � ���
            dish9.AddProduct(new Product() { name = "������� � ������", quantity = Mass.FromGrams(10) }); // 1 � ���
            dish9.AddProduct(new Product() { name = "���� ����������", quantity = Volume.FromMilliliters(20) }); // 1 � ���
            dish9.AddProduct(new Product() { name = "������ ������", quantity = Mass.FromGrams(20) }); // 2 ���
            dish9.AddProduct(new Product() { name = "������ �������", quantity = Mass.FromGrams(20) }); // �� �����
            dish9.AddProduct(new Product() { name = "������ ��������", quantity = Mass.FromGrams(10) }); // �� �����
            dish9.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(10) }); // �� �����
            dish9.AddProduct(new Product() { name = "����� ������ �������", quantity = Mass.FromGrams(10) }); // �� �����


            Dish dish10 = new Dish("������� ������ � ������� ", "������� �����"); // ������� �����
            dish10.AddProduct(new Product() { name = "���� ���� �������", quantity = Mass.FromGrams(600) }); //600 �.
            dish10.AddProduct(new Product() { name = "��� �������� ������", quantity = Mass.FromGrams(100) }); // 2 ��.
            dish10.AddProduct(new Product() { name = "��������� ������", quantity = Mass.FromGrams(200) });  // ��������� 6 ��.
            dish10.AddProduct(new Product() { name = "������� ������ ������", quantity = Mass.FromGrams(100) }); // 2 ��.
            dish10.AddProduct(new Product() { name = "����� ���������", quantity = Volume.FromMilliliters(50) }); // 7 � �����
            dish10.AddProduct(new Product() { name = "��� ������", quantity = Mass.FromGrams(150) }); // ��� ������ ������ 6 ��. �����
            dish10.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(10) }); // 10 �.


            Dish dish11 = new Dish("��������� ���", "�������"); //������
            dish11.AddProduct(new Product() { name = "���������", quantity = Mass.FromKilograms(1) }); 
            dish11.AddProduct(new Product() { name = "����� ������������", quantity = Volume.FromLiters(1) });
            dish11.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(50) });

            Dish dish12 = new Dish("��������� ��������� �� ���������", "�������"); //������
            dish12.AddProduct(new Product() { name = "��������� ������", quantity = Mass.FromKilograms(1.5) });
            dish12.AddProduct(new Product() { name = "������ ������", quantity = Mass.FromGrams(100) });
            dish12.AddProduct(new Product() { name = "����� ������������", quantity = Volume.FromMilliliters(100) });
            dish12.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(50) });

            Dish dish13 = new Dish("���", "�������"); //������
            dish13.AddProduct(new Product() { name = "���", quantity = Mass.FromGrams(150) });
            dish13.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(5) });

            Dish dish14 = new Dish("����� �� �����", "�������"); //������
            dish14.AddProduct(new Product() { name = "������� ������", quantity = Mass.FromGrams(500) });
            dish14.AddProduct(new Product() { name = "�������� ������", quantity = Mass.FromGrams(500) });
            dish14.AddProduct(new Product() { name = "������� ������", quantity = Mass.FromGrams(300) });
            dish14.AddProduct(new Product() { name = "�������� � ������", quantity = Mass.FromGrams(80) });

            Dish dish15 = new Dish("�������", "������������� �����"); // ������������� �����
            dish15.AddProduct(new Product() { name = "���� �������", quantity = Mass.FromGrams(500) });
            dish15.AddProduct(new Product() { name = "���", quantity = Mass.FromGrams(150) });
            dish15.AddProduct(new Product() { name = "������� ������ �������", quantity = Mass.FromGrams(500) });
            dish15.AddProduct(new Product() { name = "��� ��������", quantity = Mass.FromGrams(100) });
            dish15.AddProduct(new Product() { name = "������� ������", quantity = Mass.FromGrams(100) });
            dish15.AddProduct(new Product() { name = "�������� �����", quantity = Volume.FromMilliliters(50) });
            dish15.AddProduct(new Product() { name = "�������", quantity = Volume.FromMilliliters(50) });
            dish15.AddProduct(new Product() { name = "�������� ����", quantity = Mass.FromGrams(20) });
            dish15.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(20) });
            dish15.AddProduct(new Product() { name = "����� ������������", quantity = Volume.FromMilliliters(20) });

            Dish dish16 = new Dish("�������� � �����", "������������� �����"); // ������������� �����
            dish16.AddProduct(new Product() { name = "������", quantity = Volume.FromMilliliters(200) });
            dish16.AddProduct(new Product() { name = "���� �������", quantity = Scalar.FromAmount(2) });
            dish16.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(160) });
            dish16.AddProduct(new Product() { name = "�����", quantity = Mass.FromGrams(40) });
            dish16.AddProduct(new Product() { name = "����� ������������", quantity = Volume.FromMilliliters(100) });
            dish16.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(4) });

            Dish dish17 = new Dish("�������� � ��������", "������������� �����");  // ������������� �����
            dish17.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(150) });
            dish17.AddProduct(new Product() { name = "������", quantity = Volume.FromMilliliters(200) });
            dish17.AddProduct(new Product() { name = "���� �������", quantity = Scalar.FromAmount(3) });
            dish17.AddProduct(new Product() { name = "����� ������������", quantity = Volume.FromMilliliters(100) });
            dish17.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(4) });
            dish17.AddProduct(new Product() { name = "������", quantity = Mass.FromGrams(200) });
            dish17.AddProduct(new Product() { name = "�������", quantity = Volume.FromMilliliters(50) });
            dish17.AddProduct(new Product() { name = "�����", quantity = Mass.FromGrams(40) });

            Dish dish18 = new Dish("������ �������������", "������������� �����"); // ������������� �����
            dish18.AddProduct(new Product() { name = "���� ������", quantity = Mass.FromGrams(800) });
            dish18.AddProduct(new Product() { name = "������� ������", quantity = Mass.FromGrams(200) });
            dish18.AddProduct(new Product() { name = "������ ������", quantity = Mass.FromGrams(200) });
            dish18.AddProduct(new Product() { name = "���� ����� �����", quantity = Volume.FromMilliliters(200) });
            dish18.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(10) });

            Dish dish19 = new Dish("������", "������������� �����"); // ������������� �����
            dish19.AddProduct(new Product() { name = "���� ���� �������", quantity = Mass.FromGrams(400) });
            dish19.AddProduct(new Product() { name = "����� ����������", quantity = Mass.FromGrams(100) });
            dish19.AddProduct(new Product() { name = "��� �������� ������", quantity = Mass.FromGrams(100) });
            dish19.AddProduct(new Product() { name = "������", quantity = Volume.FromMilliliters(200) });
            dish19.AddProduct(new Product() { name = "����� ������������", quantity = Volume.FromMilliliters(20) });
            dish19.AddProduct(new Product() { name = "����", quantity = Mass.FromGrams(10) });


            menuCollection.addMenu(dish1);
            menuCollection.addMenu(dish2);
            menuCollection.addMenu(dish3);
            menuCollection.addMenu(dish4);
            menuCollection.addMenu(dish5);
            menuCollection.addMenu(dish6);
            menuCollection.addMenu(dish7);
            menuCollection.addMenu(dish8);
            menuCollection.addMenu(dish9);
            menuCollection.addMenu(dish10);
            menuCollection.addMenu(dish11);
            menuCollection.addMenu(dish12);
            menuCollection.addMenu(dish13);
            menuCollection.addMenu(dish14);
            menuCollection.addMenu(dish15);
            menuCollection.addMenu(dish16);
            menuCollection.addMenu(dish17);
            menuCollection.addMenu(dish18);
            menuCollection.addMenu(dish19);

        }



        internal void print() 
        {



            foreach (string s in menuCollection.menu.Keys)
            { 
             Console.WriteLine(s);
            
            
            }



        }





    }
}
