using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BarraSuplementos.Models;

namespace BarraSuplementos.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Categoria
        List<Categoria> categorias = new() {
            new Categoria() {
                Id = 1,
                Nome = "Acessórios"
            },
             new Categoria() {
                Id = 2,
                Nome = "Emagrecimento",
                Descricao = "Os melhores suplementos para atingir seu objetivo de emagrecer.",
                Imagem = "/img/emagrecerObjetivo_resized.jpg",
                Destaque = true
            },
             new Categoria() {
                Id = 3,
                Nome = "Energia e Resistência"
            },
             new Categoria() {
                Id = 4,
                Nome = "Massa Muscular",
                Descricao = "Os melhores suplementos para atingir seu objetivo de ganho de massa.",
                Imagem = "img/ganhoMassa_resized (1).jpg",
                Destaque = true
            },
             new Categoria() {
                Id = 5,
                Nome = "Naturais"
            },
             new Categoria() {
                Id = 6,
                Nome = "Pré/Pró Hormonal",
                Descricao = "Os melhores suplementos para para atingir seu objetivo de definição.",
                Imagem = "img/hipertrofia_resized.jpg",
                Destaque = true
            },
             new Categoria() {
                Id = 7,
                Nome = "Vestuário"
            },
            new Categoria() {
                Id = 8,
                Nome = "Vitamas e Minerais"
            }
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion


        #region Populate Marca
        List<Marca> marcas = new() {
            new Marca() {
                Id = 1,
                Nome = "Adaptogen"
            },

            new Marca() {
                Id = 2,
                Nome = "Atlhetica Nutrition"
            },

            new Marca() {
                Id = 3,
                Nome = "Bestronger"
            },

            new Marca() {
                Id = 4,
                Nome = "Blackskull"
            },

            new Marca() {
                Id = 5,
                Nome = "Darkness"
            },

            new Marca() {
                Id = 6,
                Nome = "Dr. Peanut"
            },

            new Marca() {
                Id = 7,
                Nome = "FTW SPORTS NUTRITION"
            },

            new Marca() {
                Id = 8,
                Nome = "Hopper"
            },

            new Marca() {
                Id = 9,
                Nome = "Integralmédica"
            },

            new Marca() {
                Id = 10,
                Nome = "Max Titanium"
            },

            new Marca() {
                Id = 11,
                Nome = "Nitromax"
            },

            new Marca() {
                Id = 12,
                Nome = "Nutrivale"
            },

            new Marca() {
                Id = 13,
                Nome = "Orion Supplements"
            },

            new Marca() {
                Id = 14,
                Nome = "Puritans Pride"
            },

            new Marca() {
                Id = 15,
                Nome = "Rock"
            },

            new Marca() {
                Id = 16,
                Nome = "Shark Pro"
            },

            new Marca() {
                Id = 17,
                Nome = "SUDRACT"
            }
        };

        builder.Entity<Marca>().HasData(marcas);
        #endregion



        #region Populate Produtos
        List<Produto> produtos = new() {
            new Produto() {
                Id = 6328,
                Nome = "Coqueteleira - BLACKSKULL",
                Descricao = "600ml, polipropileno (BPA), matéria-prima atóxica, livre de Bisfenol A e Ftalato (DEHP) COR: PRETA",
                Lancamento = true,
                QtdEstoque = 67,
                ValorAtual = 19.90M,
                Imagem = @"img/produtos/1.png",
                CategoriaId = 1,
                MarcaId = 4
            },

            new Produto() {
                Id = 1006583,
                Nome = "Coqueteleira - FTW",
                Descricao = "- Odor Free. - Antivazamento.- 600ml. ",
                Lancamento = true,
                QtdEstoque = 36,
                ValorAtual = 19.90M,
                Imagem = @"img/produtos/2.png",
                CategoriaId = 1,
                MarcaId = 1
            },

            new Produto() {
                Id = 6098,
                Nome = "Strap monster - BESTRONGER",
                Descricao = "O Strap Monster Be Stronger é um acessório essencial pra você amador e profissional da musculação, cross training, powerlifting, bodybuilding e weightlifting!",
                Lancamento = true,
                QtdEstoque = 24,
                ValorAtual = 69.90M,
                Imagem = @"img/produtos/3.png",
                CategoriaId = 1,
                MarcaId = 3
            },

            new Produto() {
                Id = 1006531,
                Nome = "Coqueteleira com mola - INTEGRALMÉDICA",
                Descricao = "Antivazamento.- 600ml. ",
                Lancamento = true,
                QtdEstoque = 17,
                ValorAtual = 24.90M,
                Imagem = @"img/produtos/4.jpg",
                CategoriaId = 1,
                MarcaId = 9
            },

            new Produto() {
                Id = 1006518,
                Nome = "Therma Pro Hardcore 60caps - INTEGRALMÉDICA",
                Descricao = "O Therma Pro Hardcore é um termogênico que fornece 280 mg de cafeína, ótima opção para aumentar a energia e queimar gordura.",
                QtdEstoque = 8,
                ValorAtual = 69.90M,
                Imagem = @"img/produtos/5.jpg",
                CategoriaId = 2,
                MarcaId = 9
            },

            new Produto() {
                Id = 1006940,
                Nome = "Picolinato de Cromo 60caps - FTW SPORTS NUTRITION",
                Descricao = "Apresentação: Pote com 60 cápsulas. Ingredientes: Picolinato de cromo, estabilizantes celulose microcristalina e amido, antiumectante dióxido de silício. Ingredientes da cápsula: Gelatina, opacificante dióxido de titânio e água potável filtrada.",
                QtdEstoque = 7,
                ValorAtual = 59.90M,
                Imagem = @"img/produtos/6.jpg",
                CategoriaId = 2,
                MarcaId = 7
            },

            new Produto() {
                Id = 6472,
                Nome = "Thermo CAPS 60caps - DIABO VERDE FTW",
                Descricao = "O Diabo Verde é um pré-treino em cápsulas para atletas a base de cafeína que atua no aumento da capacidade de resistência e no desempenho de exercícios físicos.",
                QtdEstoque = 7,
                ValorAtual = 74.90M,
                Imagem = @"img/produtos/7.jpg",
                CategoriaId = 2,
                MarcaId = 7
            },

            new Produto() {
                Id = 1006987,
                Nome = "Thermoflame 60caps - BLACKSKULL",
                Descricao = "O THERMO FLAME entrega 360mg de cafeína pura por dose, proporcionando mais energia e foco, otimizando os resultados na busca pelo emagrecimento.",
                QtdEstoque = 6,
                ValorAtual = 59.90M,
                Imagem = @"img/produtos/8.jpg",
                CategoriaId = 2,
                MarcaId = 11
            },

            new Produto() {
                Id = 6228,
                Nome = "Termogêmico Nitrofire 60caps - NITROMAX",
                Descricao = "NITRO FIRE 420mg é um suplemento a base de cafeína. Sua fórmula exclusiva além de dar um ânimo de imediato e duradouro, aumenta a termogênese do atleta!",
                QtdEstoque = 1,
                ValorAtual = 65M,
                Imagem = @"img/produtos/9.jpg",
                CategoriaId = 2,
                MarcaId = 11

            },

            new Produto() {
                Id = 1007058,
                Nome = "Alfajor Avelã 55g - DR. PEANUT",
                Descricao = "omos conhecidos por nosso sabor inigualável e agora realizamos o sonho de todos os amantes de alfajor com nossa versão dessa maravilha. Composta por duas camadas de leves e crocantes bolachas, recheadas com a famosa pasta de amendoim Dr. Peanut e cobertas com chocolate zero açúcar. Sabor e textura inconfundíveis, com ingredientes de altíssima qualidade. Experimente! ",
                QtdEstoque = 52,
                ValorAtual = 12.90M,
                Imagem = @"img/produtos/10.jpg",
                CategoriaId = 3,
                MarcaId = 6
            },

            new Produto() {
                Id = 1007055,
                Nome = "Alfajor Chocolante Branco 55g - DR. PEANUT",
                Descricao = "Somos conhecidos por nosso sabor inigualável e agora realizamos o sonho de todos os amantes de alfajor lançando nossa versão dessa maravilha. Composta por duas camadas de leves e crocantes bolachas, recheadas com a famosa pasta de amendoim Dr. Peanut e cobertas com chocolate zero açúcar. Sabor e textura inconfundíveis com ingredientes de altíssima qualidade. Experimente!",
                QtdEstoque = 39,
                ValorAtual = 12.90M,
                Imagem = @"img/produtos/11.jpg",
                CategoriaId = 3,
                MarcaId = 6
            },

            new Produto() {
                Id = 1006966,
                Nome = "Dr Peanut Buenissimo 600g - DR. PEANUT",
                Descricao = "Quem é #DoctorLover de verdade sabe que essa é uma das queridinhas, né! A combinação perfeita da pasta de amendoim com chocolate, avelã e wafer, sem adição de açúcar e zero glúten só poderia resultar nessa delícia. Garanta já a sua e leve esse sabor especial para o seu dia a dia mais saudável!",
                QtdEstoque = 36,
                ValorAtual = 59.90M,
                Imagem = @"img/produtos/12.jpg",
                CategoriaId = 3,
                MarcaId = 6
            },

            new Produto() {
                Id = 1007074,
                Nome = "Hydramaxi Morango com maracujá 20g - SUDRACT",
                Descricao = "Como preparar: diluir 20g (uma colher de sopa) do produto em 500ml de água gelada, mexer até que o produto se dissolva e estará pronto para o consumo; indicados para adultos praticantes de atividade. Repõe os eletrólitos perdidos no suor; - evita câimbras e desidratação; - melhor desempenho; - baixa caloria",
                QtdEstoque = 17,
                ValorAtual = 3.95M,
                Imagem = @"img/produtos/13.jpg",
                CategoriaId = 3,
                MarcaId = 17
            },

            new Produto() {
                Id = 1006972,
                Nome = "Dr Peanut Leite em pó 600g - DR. PEANUT",
                Descricao = "Aquele sabor de infância que só a Doctor Leite em Pó pode te proporcionar! Aliada e coringa de todas as refeições, além de ter zero adição de açúcar e zero glúten, essa delícia é perfeita para o seu dia a dia. Desde o café da manhã mais completo, até um lanchinho rápido e saudável, esse sabor vai te conquistar",
                QtdEstoque = 10,
                ValorAtual = 79.90M,
                Imagem = @"img/produtos/14.jpg",
                CategoriaId = 3,
                MarcaId = 6
            },

            new Produto() {
                Id = 1006951,
                Nome = "Dilabol Black 120caps - FTW SPORTS NUTRITION",
                Descricao = "O que é o #Dilabol Black da FTW? Cada substância escolhida para o #Dilabol Black Diabo Verde foi pensada exclusivamente para o melhor desempenho das vias metabólicas do nosso organismo a combinação perfeita para o seu treino Hard!",
                QtdEstoque = 8,
                ValorAtual = 99.90M,
                Imagem = @"img/produtos/15.jpg",
                CategoriaId = 3,
                MarcaId = 7

            },

            new Produto() {
                Id = 1006971,
                Nome = "Dr Peanut Avelã 600g - DR. PEANUT",
                Descricao = "Essa é a pasta de amendoim dos seus sonhos, com o sabor irresistível de Avelã! Nossa receita faz com que ela seja incrivelmente cremosa, deliciosamente saborosa e perfeita para uma alimentação saudável. Feita com ingredientes de alta qualidade, sem adição de açúcar e sem glúten, cada colherada é uma explosão de sabores, com a combinação perfeita de amendoim e avelã. Experimente, seu lanche nunca mais será o mesmo! ",
                QtdEstoque = 8,
                ValorAtual = 59.90M,
                Imagem = @"img/produtos/16.jpg",
                CategoriaId = 3,
                MarcaId = 6
            },

            new Produto() {
                Id = 1006545,
                Nome = "Cindy Bar Doce de coco 45g - HOPPER",
                Descricao = "A Cindy Bar sabor Doce de Coco, da Hopper, é uma barrinha que fornece 13 g de proteínas de alto valor biológico, com adição de TCM, carboidratos de baixo índice glicêmico além de um mix de vitaminas e minerais.",
                QtdEstoque = 96,
                ValorAtual = 9.50M,
                Imagem = @"img/produtos/17.jpg",
                CategoriaId = 4,
                MarcaId = 8
            },

            new Produto() {
                Id = 1007039,
                Nome = "Whey Ftw 100% Cookies 900g refil - FTW",
                Descricao = "O que é 100% Whey Protein Apresenta variedade e praticidade em um só produto. Praticantes de atividade física ou quem busca uma rotina alimentar com bons nutrientes se beneficia do uso das proteínas do soro do leite, que fornecem qualidade nutricional com alto valor biológico. Contém grande concentração de proteínas e aminoácidos (rico em Bcaas e Glutamina) que são essenciais para os processos de ganho, recuperação e manutenção muscular. ",
                QtdEstoque = 96,
                ValorAtual = 149.90M,
                Imagem = @"img/produtos/18.jpg",
                CategoriaId = 4,
                MarcaId = 7
            },

            new Produto() {
                Id = 1007036,
                Nome = "Whey Ftw 100% Chocolate 900g refil - FTW",
                Descricao = "O que é 100% Whey Protein Apresenta variedade e praticidade em um só produto. Praticantes de atividade física ou quem busca uma rotina alimentar com bons nutrientes se beneficia do uso das proteínas do soro do leite, que fornecem qualidade nutricional com alto valor biológico. Contém grande concentração de proteínas e aminoácidos (rico em Bcaas e Glutamina) que são essenciais para os processos de ganho, recuperação e manutenção muscular. ",
                QtdEstoque = 87,
                ValorAtual = 149.90M,
                Imagem = @"img/produtos/19.jpg",
                CategoriaId = 4,
                MarcaId = 7
            },

            new Produto() {
                Id = 1006499,
                Nome = "Top Whey Bar Brigadeiro 41g - MAX TITANIUM",
                Descricao = "Proteína e Emagrecimento A proteína é um nutriente que nos traz sensação de saciedade. No emagrecimento, o lanche rico em proteína irá auxiliar o controle da ingestão entre as refeições. Para quem visa o ganho de massa muscular, colocar proteína nos lanches é uma excelente estratégia para o consumo da necessidade proteica diária e, as barrinhas trazem muita praticidade e sabor!",
                QtdEstoque = 86,
                ValorAtual = 8M,
                Imagem = @"img/produtos/20.jpg",
                CategoriaId = 4,
                MarcaId = 10
            },

            new Produto() {
                Id = 1006498,
                Nome = "Top Whey Bar Chocolate com Avelã 41g - MAX TITANIUM",
                Descricao = "Proteína e Emagrecimento A proteína é um nutriente que nos traz sensação de saciedade. No emagrecimento, o lanche rico em proteína irá auxiliar o controle da ingestão entre as refeições. Para quem visa o ganho de massa muscular, colocar proteína nos lanches é uma excelente estratégia para o consumo da necessidade proteica diária e, as barrinhas trazem muita praticidade e sabor!",
                QtdEstoque = 82,
                ValorAtual = 8M,
                Imagem = @"img/produtos/21.jpg",
                CategoriaId = 4,
                MarcaId = 10
            },

            new Produto() {
                Id = 1007037,
                Nome = "Whey Ftw 100% Morango 900g refil - FTW",
                Descricao = "O que é 100% Whey Protein Apresenta variedade e praticidade em um só produto. Praticantes de atividade física ou quem busca uma rotina alimentar com bons nutrientes se beneficia do uso das proteínas do soro do leite, que fornecem qualidade nutricional com alto valor biológico. Contém grande concentração de proteínas e aminoácidos (rico em Bcaas e Glutamina) que são essenciais para os processos de ganho, recuperação e manutenção muscular. ",
                QtdEstoque = 63,
                ValorAtual = 149.90M,
                Imagem = @"img/produtos/22.jpg",
                CategoriaId = 4,
                MarcaId = 7
            },

            new Produto() {
                Id = 1006959,
                Nome = "Dark Bar Creme de coco com castanha 90G -  DARKNESS",
                Descricao = "Aumento de força muscular; Ganho de massa muscular; Aumento na saciedade; Recuperação muscular; Energia",
                QtdEstoque = 56,
                ValorAtual = 16.90M,
                Imagem = @"img/produtos/23.jpg",
                CategoriaId = 4,
                MarcaId = 5
            },

            new Produto() {
                Id = 1006621,
                Nome = "CRISP BAR Duo Crunch 45g - INTEGRALMÉDICA",
                Descricao = "A Protein Crisp é formada por 13g proteínas de alto valor biológico. Essas proteínas são fundamentais para a construção de muscular, além de serem importantes para a manutenção da massa muscular em programas de perda de peso. Por isso a Protein Crisp pode ser consumida tanto em dietas para perda de peso, quanto em dietas para ganho de massa muscular. Por ser uma barra de proteína completa, com proteínas, gorduras essenciais e aminoácidos, sua ingestão aumenta a saciedade entre as refeições, diminuindo a vontade de comer doces e alimentos calóricos.",
                QtdEstoque = 50,
                ValorAtual = 8M,
                Imagem = @"img/produtos/24.jpg",
                CategoriaId = 4,
                MarcaId = 9
            },

            new Produto() {
                Id = 32,
                Nome = "Creatina 300g - INTEGRALMÉDICA",
                Descricao = "Ganhe volume e massa muscular, aumente sua força e melhore o desempenho e resistência nos seus treinos suplementando com a Creatina Hardcore Integralmédica. Produto 100% puro, de excelente qualidade.",
                QtdEstoque = 49,
                ValorAtual = 149.90M,
                Imagem = @"img/produtos/25.jpg",
                CategoriaId = 4,
                MarcaId = 9
            },

            new Produto() {
                Id = 1006622,
                Nome = "Cracker Monster Chocolate Branco - ROCK",
                Descricao = "O Cracker Monster ROCK é um saboroso e delicioso cracker, coberto com chocolate e recheado com a Pasta de Amendoim Branco ROCK, tudo isso ZERO açúcar, com proteína WheyRock, ótimo valor nutricional e sabor totalmente insano",
                QtdEstoque = 44,
                ValorAtual = 6.90M,
                Imagem = @"img/produtos/26.jpg",
                CategoriaId = 4,
                MarcaId = 15
            },

            new Produto() {
                Id = 1007107,
                Nome = "Creatina 300g - SHARK PRO",
                Descricao = "Potencialize Seu Desempenho Nossa Energy Creatina é a aliada perfeita para impulsionar seu desempenho atlético e alcançar novos patamares nos treinos. Sendo monohidratada e saborosa, essa creatina em pó é ideal para quem busca resultados eficazes e uma experiência saborosa. Com uma fórmula de alta qualidade, a Energy Creatina fornece a dose necessária desse poderoso suplemento alimentar, contribuindo para aumentar a força, a resistência e a recuperação muscular.",
                QtdEstoque = 42,
                ValorAtual = 119.90M,
                Imagem = @"img/produtos/27.jpg",
                CategoriaId = 4,
                MarcaId = 16
            },

            new Produto() {
                Id = 6414,
                Nome = "Ômega 3 60caps - ATLHETICA NUTRITION",
                Descricao = "Nutrientes essenciais utilizados como combustíveis para as células e uma das fontes de energia, os ácidos graxos não são produzidos pelo corpo, mas são muito importantes para nosso organismo. O ômega 3 é um ácido graxo e pode ser encontrado em peixes de água fria ou suplementos alimentares de forma concentrada e pura.",
                QtdEstoque = 2,
                ValorAtual = 39.90M,
                Imagem = @"img/produtos/28.jpg",
                CategoriaId = 5,
                MarcaId = 2
            },

            new Produto() {
                Id = 1007093,
                Nome = "Tribulus GOLD 90caps - ORION SUPPLEMENTS",
                Descricao = "O Tribulus Terrestris Gold da Orion Supplements é um suplemento nutricional formulado para ajudar a aumentar a energia, a resistência e a força física. A fórmula avançada combina os benefícios do Tribulus Terrestris com outros ingredientes naturais cuidadosamente selecionados para ajudar a melhorar o desempenho físico e sexual.",
                QtdEstoque = 4,
                ValorAtual = 167M,
                Imagem = @"img/produtos/29.jpg",
                CategoriaId = 6,
                MarcaId = 13
            },

            new Produto() {
                Id = 6344,
                Nome = "Camisa / Regata - MAX TITANIUM",
                Descricao = "A Regata Preta Basquete Max Titanium - Edição Limitada é uma opção moderna e estilosa para quem pratica esportes, oferecendo conforto e liberdade de movimento.",
                QtdEstoque = 14,
                ValorAtual = 49.90M,
                Imagem = @"img/produtos/30.jpg",
                CategoriaId = 7,
                MarcaId = 10
            },

             new Produto() {
                Id = 268,
                Nome = "Multivitaminico 60caps - FTW",
                Descricao = "APRESENTAÇÃO: Pote com 60 cápsulas. INGREDIENTES: Acetato de retinol, picolinato de cromo, bisglicinato de cobre, tiamina mononitrato, riboflavina, cloridrato piridoxina, cianocobalamina, ácido ascórbico, vitamina D3 (colecalciferol), acetato de tocoferol, nicotinamida, pantotenato de cálcio, sulfato de manganês, sulfato de zinco, óxido de magnésio, estabilizantes celulose microcristalina e amido de milho e antiumectante dióxido de silício.",
                QtdEstoque = 22,
                ValorAtual = 24.90M,
                Imagem = @"img/produtos/31.jpg",
                CategoriaId = 8,
                MarcaId = 7
            },

            new Produto() {
                Id = 1007005,
                Nome = "4 Sleep 90caps - INTEGRALMÉDICA",
                Descricao = "4-SLEEP possui a combinação de quatro compostos ativos que em conjunto atuam na indução do sono mais profundo e reparador",
                QtdEstoque = 2,
                ValorAtual = 69.90M,
                Imagem = @"img/produtos/32.jpg",
                CategoriaId = 8,
                MarcaId = 12
            },

            new Produto() {
                Id = 1007094,
                Nome = "Melatonina 120caps - GNC",
                Descricao = "Melatonina 3mg GNC  é um suplemento ideal para pessoas que possuem dificuldades para dormir ou que querem melhorar ainda mais a qualidade do sono. Com a Melatonina é possível dormir menos horas e melhor, pois a melatonina vai te levar ao sono REM mais rapidamente. É impressionante como acordamos melhor ao utilizar a melatonina logo antes de dormir. A melatonina é um hormônio natural que o seu corpo já produz, portanto é 100% seguro o uso deste produto.",
                QtdEstoque = 2,
                ValorAtual = 140M,
                Imagem = @"img/produtos/33.jpg",
                CategoriaId = 8,
                MarcaId = 12
            },

            new Produto() {
                Id = 1007095,
                Nome = "5-HTP 60Caps - PURITANS PRIDE",
                Descricao = "O que é 5-HTP? O aminoácido 5-HTP — também conhecido como 5-hidroxitriptofano — vai agir no cérebro e no sistema nervoso central como ator principal para a formação de serotonina, aumentando sua produção.",
                QtdEstoque = 1,
                ValorAtual = 180M,
                Imagem = @"img/produtos/34.jpg",
                CategoriaId = 8,
                MarcaId = 14
            }
        };
        builder.Entity<Produto>().HasData(produtos);
        #endregion

        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Funcionário",
               NormalizedName = "FUNCIONARIO"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Cliente",
               NormalizedName = "CLIENTE"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "admin@barrasuplementos.com",
                NormalizedEmail = "ADMIN@BARRASUPLEMENTOS.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "barra123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "José Roberto Grigolato",
                DataNascimento = DateTime.Parse("01/01/1990"),
                Foto = "/img/usuarios/avatar.jpg"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion



    }
}