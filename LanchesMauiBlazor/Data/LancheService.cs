
using LanchesLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LanchesMauiBlazor.Data;

public class LancheService : ILancheService
{
    public async Task<List<Lanche>>? LoadLanchesAsync()
    {
        await Task.Delay(1000);

        List<Lanche> lanches =
        [
            new Lanche(){Name = "Cheese Burger", Description = "Pão e Hamburger Tradicional com queijo" },
            new Lanche(){Name = "Cheese Salada", Description = "Pão e Hamburger tradicional com queijo e alface" },
            new Lanche(){Name = "Cheese Salada Egg", Description = "Pão e Hamburger Tradicional com queijo e alface e ovo" },
            new Lanche(){Name = "Misto Quente", Description = "Pão de forma, presunto e queijo" },
            new Lanche(){Name = "Bauru", Description = "Pão de forma, presunto, queijo, tomate e queijo" }
        ];

        return lanches;
    }
}
