using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Infaillible 24H",
                        Description = "L’association d’une couleur vibrante",
                        ProductDetails = "La nouvelle formule Infaillible 24h* offre un teint parfait, comme fraichement maquillé, qui résiste à tous les aléas de la journée.L’alliance parfaite entre agents absorbeurs de sébum et agents hydratants garantit une peau matifiéelumineusesans brillance et confortable toute la journée.La nouvelle formule technologie Oxygen offre une texture fluide,ultra - étirable et facile à appliquer.Elle se dépose en un voile homogène à la couvrance modulable qui laisse la peau respirer.La peau est lisse,douce,confortable et sans effet matière.",
                        Category = "MAQUILLAGE",
                        Price = 14m,
                        Image = "infaillible-24h-rouge-a-levres-duo.jpg",
                    },
                    new Product
                    {
                        Name = "Accord Parfait",
                        Description = "Découvrez la nouvelle formule",
                        ProductDetails = "Découvrez la nouvelle formule de votre fond de teint unifiant Accord Parfait. Désormais disponible en 48 teintes qui s’accordent à 100 % des femmes du monde *Une nouvelle formule qui s’accorde à votre peau : des pigments ultra fins qui s’adaptent aux tonalités et sous tons de la peau pour un résultat homogène sans démarcation.Une texture fine et fondante qui fusionne avec la peau et dissimule tous types d’imperfections pour une couvrance naturelle parfaite. Améliore la qualité de la peau dès 2 semaines * * : la peau est visiblement plus lisse et éclatante de beauté.Sa formule infusée en Acide Hyaluronique et en Aloe Vera, contient 80 % de soin hydratant pour une hydratation 24H * **.Pour une peau nue plus lisse, lumineuse et unifiée.Sa formule unique protège contre les agressions extérieures(pollution et UVs).",
                        Category = "MAQUILLAGE",
                        Price = 48.95m,
                        Image = "accord-parfait-fluide.jpg",
                    },
                    new Product
                    {
                        Name = "Color Riche Rouge",
                        Description = "Rouge à lèvres soin confort extrême.",
                        ProductDetails = "Rouge à lèvres soin confort extrême. Une texture voluptueuse qui gorge vos lèvres d’hydratation et les préserve du desséchement. Une palette de couleurs intenses et éclatantes. Appliquer le rouge à lèvres directement sur la bouche du centre vers l'extérieur. Pour un résultat irréprochable, appliquer le Lip Liner Color Riche pour définir le contour de vos lèvres.",
                        Category = "MAQUILLAGE",
                        Price = 19.50m,
                        Image = "color-riche-rouge-a-levres.jpg",
                    },
                    new Product
                    {
                        Name = "Accord Parfait Poudre",
                        Description = "UNE TEXTURE ULTRA-CRÉMEUSE",
                        ProductDetails = "Poudre fondante perfectrice et bienfaisante. UNE TEXTURE ULTRA - CRÉMEUSE, ULTRA - FINE ET D’UNE DOUCEUR EXTRÊME : enrichie en pigments minéraux, la poudre Accord Parfait améliore la qualité de la peau.UNE FUSION ULTIME AVEC LA PEAU : la poudre Accord Parfait s’accorde parfaitement à la couleur et à la texture de la peau, sans effet masque ni surcharges pour une perfection ultime, 10h * durant.La peau respire! UNE COUVRANCE MODULABLE : grâce à sa poudre si fine et si fondante, la poudre Accord Parfait permet de matifier, unifier ou masquer selon vos besoins. UNE PALETTE DE NUANCES NATURELLES : pour une couleur vraie qui reste parfaite au fil des heures. RÉSULTAT : un teint parfaitement naturel, unifié sur mesure. TESTE SOUS CONTROLE DERMATOLOGIQUE.",
                        Category = "MAQUILLAGE",
                        Price = 20m,
                        Image = "accord-parfait-poudre.jpg",
                    },
                    new Product
                    {
                        Name = "Méga Palette Ombres",
                        Description = "9 TEINTES",
                        ProductDetails = "9 TEINTES POUR UNE INFINITÉ DE LOOKS. Cette méga palette de fards à paupières vous permet de changer de look en fonction de vos envies.Ses 9 teintes, de la plus neutre à la plus sophistiquée en passant par des teintes plus osées, représentent parfaitement le style rock chic iconique de Karl Lagerfeld. DES COULEURS INTENSES ET UNE TEXTURE DOUCE Un résultat coloriel intense grâce à une formule très concentrée en pigments et une texture douce qui permet une application tout en légèreté.",
                        Category = "MAQUILLAGE",
                        Price = 17m,
                        Image = "mega-palette-ombres-a-paupieres-karl-lagerfeld-x-loreal-paris.jpg",
                    },
                    new Product
                    {
                        Name = "Infaillible 24h Fond",
                        Description = "La nouvelle formule Infaillible 24h",
                        ProductDetails = "La nouvelle formule Infaillible 24h* offre un teint parfait, comme fraichement maquillé, qui résiste à tous les aléas de la journée. L’alliance parfaite entre agents absorbeurs de sébum et agents hydratants garantit une peau matifiée, lumineuse, sans brillance et confortable toute la journée. La nouvelle formule technologie Oxygen offre une texture fluide, ultra - étirable et facile à appliquer.Elle se dépose en un voile homogène à la couvrance modulable qui laisse la peau respirer.La peau est lisse, douce, confortable et sans effet matière. Le fond de teint ne transfère pas",
                        Category = "MAQUILLAGE",
                        Price = 16m,
                        Image = "infaillible-24h-fond-de-teint-fluide.jpg",
                    },
                    new Product
                    {
                        Name = "Mascara Lash",
                        Description = "Votre mascara Paradise",
                        ProductDetails = "Votre mascara Paradise, dans une formule améliorée qui enverra vos cils tout droit au Paradis ! VOLUME INTENSE ET LONGUEUR PRODIGIEUSE. Le mascara Lash Paradise de L'Oréal Paris est enrichi en pigments noirs intenses pour un volume noir intense sur mesure et une longueur prodigieuse, sans paquets. 93 % ont constaté des cils intenses et volumineux * * +98 % de longueur des cils * * PLAISIR DIVIN À L'APPLICATION Adaptée aux yeux sensibles,sa formule infusées d'huile de ricin nourrissante, d’huile de rose antioxydant et d’extrait de bleuet est douce pour vos yeux et ne sèche pas. Sa brosse ultra-douce épouse chaque cil, même les plus fins, pour un plaisir divin à lapplication.91 % ont constaté des cils souples * ",
                        Category = "MAQUILLAGE",
                        Price = 29.95m,
                        Image = "mascara-lash-paradise-noir.jpg",
                    },
                    new Product
                    {
                        Name = "Volume Millions",
                        Description = "Brosse elastomère Millionizer",
                        ProductDetails = "Brosse elastomère Millionizer + essoreur-doseur sans surcharge. Formule volumatrice gainanteVolume + définition : comme démultipliés, cils 3x plus épais.Zéro paquets.",
                        Category = "MAQUILLAGE",
                        Price = 15m,
                        Image = "volume-millions-de-cils.jpg",
                    },
                    new Product
                    {
                        Name = "Revitalift Filler",
                        Description = "Le Sérum Revolumisant",
                        ProductDetails = "Le Sérum Revolumisant Hyaluronique Revitalift Filler comble les rides et repulpe la peau. Des résultats visibles : Dès 4 heures, la peau est parfaitement hydratée, plus tonique(+26 %), plus élastique(+13 %) et plus ferme(+10 %) *. En 4 semaines, les rides sont réduites sous les yeux(-20 %), sur le front(-11 %) et sur la lèvre supérieure(-14 %) * *.La peau est plus rebondie.",
                        Category = "SOIN DE LA PEAU",
                        Price = 12m,
                        Image = "revitalift-filler--acide-hyaluronique.jpg",
                    },
                    new Product
                    {
                        Name = "Revitalift Filler",
                        Description = "Le Soin Revolumisant anti-âge",
                        ProductDetails = "Le Soin Revolumisant anti-âge Revitalift Filler comble les rides et restaure les volumes du visage. Composé d acide hyaluronique, il repulpe la peau.Résultats : Dès 4 heures, le matelas cutané est plus ferme(+14 %) et plus toniques(+25 % *).La peau est hydratée pour 48H. En 4 semaines,  une réduction significative des rides du front(-16 %) et de la patte d'oie (-11%) est mesurée**. La peau est repulpée,les volumes du visage sont visiblement restaurés",
                        Category = "SOIN DE LA PEAU",
                        Price = 12m,
                        Image = "revitalift-filler--acide-hyaluronique-jour.jpg",
                    },
                    new Product
                    {
                        Name = "Revitalift Soin Rouge",
                        Description = "Le soin rouge défatigant",
                        ProductDetails = "L’Oréal Paris Revitalift Soin Rouge Défatigant 50 ml. Le soin rouge défatigant Revitalift de L’Oréal Paris est un soin anti - rides qui ravive l'éclat naturel du teint et lisse la peau. Enrichi en pro - rétinol avancé et en ginseng rouge, il aide à lisser les rides et à booster la peau pour lutter contre les signes de l’âge et de fatigue. Immédiatement, l éclat naturel est ravivé, la peau paraît reposée, plus lumineuse et plus jeune. En 1 semaine, la peau est plus ferme et plus lisse.En 4 semaines, les rides et les ridules sont visiblement réduites.La peau est plus éclatante. Appliquer votre crème rouge le matin par mouvements ascendants, sur le visage et le cou préalablement nettoyés.",
                        Category = "SOIN DE LA PEAU",
                        Price = 12m,
                        Image = "revitalift-soin-rouge-defatigant-jour.jpg",
                    },
                    new Product
                    {
                        Name = "Revitalift Sérum ",
                        Description = "Avec le temps, deux types de rides",
                        ProductDetails = "Avec le temps, deux types de rides peuvent marquer votre visage : les rides horizontales et les rides verticales. Les rides verticales sont les plus difficiles à réduire. Ce sont aussi celles qui durcissent vos expressions et peuvent parfois vous donner un air triste ou fatigué. Le sérum anti-rides + extra-fermeté est ultra-concentré en actifs anti-âge. Il agit immédiatement sur tous les types de rides. L'Adenosine, puissant actif anti-rides aide à combattre les signes du vieillissement. Le Fibrelastyl, complexe raffermissant participe à renforcer la tonicité de la peau pour une peau extra-ferme. Immédiatement la peau est hydratée et lissée.Après 4 semaines, les différents types de rides sont réduites.",
                        Price = 12m,
                        Image = "revitalift-serum-hydratant-lissant.jpg",
                    },
                    new Product
                    {
                        Name = "Excellence Pure",
                        Description = "Un blond ultra-pur, intensément",
                        ProductDetails = "Un blond ultra-pur, intensément riche et lumineux qui convient aux cheveux blonds très très clairs à blonds foncés. Technologie Hi - Lift, éclaircit jusqu'à 4 tons tout en neutralisant les reflets indésirables. Votre ultra-blond ne vire pas au jaune. Une crème colorante triple soin qui couvre jusqu'à 100% des cheveux blancs. Une routine en 3 étapes qui prend soin de vos cheveux et les respecte avec : 1) Une crème colorante protectrice enrichie en pro - kératine. 2) Un nouveau shampooing soin au pH doux post-coloration qui nettoie délicatement le cuir chevelu. 3) Un masque nutritif légèreté qui rend la chevelure brillante, douce et légère. Pour une couleur riche, lumineuse et soyeuse longue durée.",
                        Category = "COLORATION",
                        Price = 12m,
                        Image = "excellence-pure-blonde.jpg",
                    },
                    new Product
                    {
                        Name = "Excellence Crème Brunette",
                        Description = "Un brun profond naturel ",
                        ProductDetails = "Un brun profond naturel qui convient aux cheveux châtains à noirs. Crème colorante triple soin qui couvre jusqu'à 100% des cheveux blancs. Une routine en 3 étapes qui prend soin de vos cheveux et les respecte. 1) Crème colorante protectrice enrichie en pro-kératine. 2) Nouveau shampooing soin au pH doux qui nettoie délicatement le cuir chevelu. 3) Masque nutritif qui rend la chevelure brillante, douce et légère. Couleur riche, lumineuse et soyeuse.",
                        Category = "COLORATION",
                        Price = 12m,
                        Image = "excellence-creme-brunette.jpg",
                    },
                    new Product
                    {
                        Name = "Excellence Crème Châtain",
                        Description = "Un châtain profond et nature",
                        ProductDetails = "Un châtain profond et naturel qui convient aux cheveux châtain clair à châtain foncé.Une crème colorante triple soin qui couvre jusqu'à 100% des cheveux blancs. Une routine en 3 étapes qui prend soin de vos cheveux et les respecte avec : 1) Une crème colorante protectrice enrichie en pro - kératine. 2) Un nouveau shampooing soin au pH doux post-coloration qui nettoie délicatement le cuir chevelu 3) Un masque nutritif légèreté qui rend la chevelure brillante, douce et légère. Pour une couleur riche, lumineuse et soyeuse longue durée.",
                        Category = "COLORATION",
                        Price = 12m,
                        Image = "excellence-creme-chatain.jpg",
                    },
                    new Product
                    {
                        Name = "Excellence Crème Brunes",
                        Description = "Un châtain foncé profond et naturel",
                        ProductDetails = "Un châtain foncé profond et naturel qui convient aux cheveux châtain clair à brun. Une crème colorante triple soin qui couvre jusqu'à 100% des cheveux blancs. Une routine en 3 étapes qui prend soin de vos cheveux et les respecte avec : 1) Une crème colorante protectrice enrichie en pro - kératine. 2) Un nouveau shampooing soin au pH doux post-coloration qui nettoie délicatement le cuir chevelu 3) Un masque nutritif légèreté qui rend la chevelure brillante, douce et légère. Pour une couleur riche, lumineuse et soyeuse longue durée.",
                        Category = "COLORATION",
                        Price = 12m,
                        Image = "excellence-creme-brunes.jpg",
                    },
                    new Product
                    {
                        Name = "Excellence Crème Reflets",
                        Description = "Un blond foncé aux reflets acajou",
                        ProductDetails = "Un blond foncé aux reflets acajou intenses qui convient aux cheveux blond clair à châtain clair. Crème colorante triple soin qui couvre jusqu'à 100% des cheveux blancs. Une routine en 3 étapes qui prend soin de vos cheveux et les respecte. 1) Crème colorante protectrice enrichie en pro-kératine. 2)Nouveau shampooing soin au pH doux qui nettoie délicatement le cuir chevelu 3) Masque nutritif qui rend la chevelure brillante, douce et légère. Couleur riche, lumineuse et soyeuse.",
                        Category = "COLORATION",
                        Price = 12m,
                        Image = "excellence-creme-reflets.jpg",
                    },
                    new Product
                    {
                        Name = "Elsève Full Resist",
                        Description = "Le Shampooing Booster de force.",
                        ProductDetails = "Le Shampooing Booster de force avec sa formule enrichie en compléments capillaires (Biotine + Vitamine B5 + Arginine). Nourrit le cuir chevelu. Renforce les longueurs. 2x plus de résistance *. Vos cheveux résistent à toutes les épreuves!. * test instrumental",
                        Category = "CHEVEUX",
                        Price = 12m,
                        Image = "3600523882120_1_XXL.jpg",
                    },
                    new Product
                    {
                        Name = "Coffret Men Expert",
                        Description = "L'Oréal Men Expert - Vita Lift.",
                        ProductDetails = "L'Oréal Men Expert - Vita Lift - Coffret 3 Produits Routine Anti-Age Homme composé d'un Soin Hydratant, d'un Soin Yeux, et d'un Déodorant Bille). Parfait pour votre routine du matin",
                        Category = "HOMME",
                        Price = 12m,
                        Image = "coffret-men-expert-vita-lift-3-produits.jpg",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

