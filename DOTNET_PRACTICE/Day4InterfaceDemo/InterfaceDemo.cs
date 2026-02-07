using System;

namespace Day4InterfaceDemo
{
    interface IAdd
    {
        int AddMe(int num1, int num2);
    }
    interface ISub
    {
        int SubMe(int num1, int num2);
    }
    interface IProd
    {
        int ProdMe(int num1, int num2);
    }
    interface IDiv
    {
        float DivMe(int num1, int num2);
    }

    //multiple inheritance in interface
    interface IAddSub : IAdd, ISub
    {
        
    }
    interface IAddProdDiv : IAdd, IProd, IDiv
    {
        
    }
    interface IAll : IAdd, ISub, IDiv
    {
        
    }
}