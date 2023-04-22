namespace Projet
{
    internal class Program
    {
        //J'ai pas les 3 class pour le projet mais voilà mon programme toutefois
        //J'ai décider d'utilsier des ints aux lieux de true and false avec des bools mais il ont factuellement la même fonction dans le programme
        //Parce que je concidere juste si c'est 0 ou 1, où 1 est considérer comme des True
        //J'avais  juste des problèmes dans mes loops pour une raison qui m'échappe...
        static int Bucketisfound = 0; //Sert à contenir le liquide pour le produit et l'eau.
        static int bucketisfilled = 0; // Sert à remplir le sceau d'eau.
        static int truekeyisfound = 0; // Si le sceau est trouvé et remplis d'eau, la clé apparait.

        static void Main(string[] args)
        {
            int y = 0; //Sers juste pour faire looper le message vous attendez encore.
            int A = 0; //Sers pour la fin troll lorsque le joueur demande trop d'aide.
            int C = 0; //Sers à loop la première salle.
            int D = 0; //Sers à loop ma deuxième salle.
            int f = 0; //Pour indiquer que le joueur à déjà un sceau.
            int G = 0; //Pour indiquer que le joueur à déjà la manette.
            int I = 0; //Je le garder pour me permettre de revenir à la 2ième salle, je pense pas que ça soit nécessaire obligatoirement mais c'est plus simple pour moi
            int az = 0; //Pour indiquer que le joueur à déjà remplis son sceau d'eau.
            int ab = 0; //Pour indiquer que le joueur à déjà utiliser le produit correctement.
            // int x sert à
            Console.WriteLine("Après une soirée assez arrosée, vous vous retrouvez entre 4 murs qui ne nous dit rien.");
            Console.WriteLine("Vous étiez entrains de dormir sur du foin dans une grange lugubre!");
            Console.WriteLine("Vous vous demandez comment vous vous êtes ramasser là, mais rien ne permets de le déterminer.");
            Console.WriteLine("Perdu, vous commencer à regardez autour de vous et vous remarquer que la seule sortie est une porte bloquée très loin, dans genre 2-3 salles.");
            Console.WriteLine("Vous commencez à remarquer que vous n'êtes pas attacher. . . ");
            while (C == 0)
            {
                Console.WriteLine("Que faîtes vous?");
                Console.WriteLine("1) Attendre. . . .");
                Console.WriteLine("2) Commencer à regarder à l'entour.");
                Console.WriteLine("3) Demander de l'aide!");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0 || x >= 4)
                { Console.WriteLine("Veuillez enter une option valide...."); }
                if (x == 1)
                {
                    if (y >= 1)
                    {
                        Console.WriteLine("Vous attendez encore...");
                    }
                    else
                    {
                        y++;
                        Console.WriteLine("Vous décidez d'attendre . . . . ");
                    }
                }
                if (x == 3)
                {
                    A++;
                    Console.WriteLine("Vous criez à l'aide...");
                    if (A > 1 && A <= 3)
                    {
                        Console.WriteLine("Il se passe toujours rien . . . ");
                        continue;

                    }
                    if (A > 3)
                    {
                        Console.WriteLine("Quelqu'un ouvre la porte!");
                        Console.WriteLine("Vous remarquer que votre sauveur est... un extrateresse!");
                        Console.WriteLine("Comme vous êtes fan de E.T, vous assumer que c'est votre ami, mais on vous approchant de ce dernier, il vous zappe avec un blaster");
                        Console.WriteLine("Ce n'était pas un extrateresse sympatique comme E.T . . . .");
                        Console.WriteLine("JOKE ENDING  : Not so friendly ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Il se passe rien...");
                    }
                }
                if (x == 2)
                {
                    C++;
                    Console.WriteLine("Vous commencez à bouger, encore un peu étourdi par l'ivresse");
                    Console.WriteLine("Peut-être auriez-vous été mieux d'écouter votre meilleur ami lorsqu'il vous à demander d'arrêter de boire...");
                    Console.WriteLine("En même temps, qui s'imagine finir dans une grange bizarre au milieu de nul pars . .. ");
                    Console.WriteLine("Vous vouyez une table où plusieurs objets sont étaller");
                    Console.WriteLine("Vous remarquer diffèrents objets:");
                    Console.WriteLine("Un sceau, et une manette étrange");
                    while (D == 0)
                    {
                        Console.WriteLine("Que faîtes-vous?");
                        Console.WriteLine("1) Prendre le sceau");
                        Console.WriteLine("2) Prendre la manette étrange");
                        Console.WriteLine("3) Explorer encore une fois");
                        int E = Convert.ToInt32(Console.ReadLine());
                        if (E == 0 || E >= 4)
                        {
                            Console.WriteLine("Prenez une option valide...");
                        }

                        if (E == 1)
                        {
                            f++;
                            if (f > 1)
                            {
                                Console.WriteLine("Vous avez déjà le sceau...");
                            }
                            if (f == 1)
                            {
                                Console.WriteLine("Vous prenez le sceau...");
                                Bucketisfound = 1;

                            }
                        }
                        if (E == 2)
                        {
                            G++;
                            if (G > 1)
                            {
                                Console.WriteLine("Vous savez que la manette est inutile...");
                            }
                            else
                            {
                                Console.WriteLine("Vous prenez la manette...Vous realiser qu'elle est en plastique...");
                            }
                        }
                        if (E == 3)
                        {
                            D++;
                            Console.WriteLine("Vous vous déplacer vers l'autre pièce...");
                            Console.WriteLine("Vous voyez une fontaine d'eau proche du centre de la pièce");
                            Console.WriteLine("Et proche de là, vous voyez un produit nettoyant proche d'un table, comme c'est pratique!");
                            Console.WriteLine("Vous voyez aussi...Une porte! Liberté! ");
                            I = 0;
                            while (I == 0)
                            {
                                Console.WriteLine("Que faîtes-vous?");
                                Console.WriteLine();
                                Console.WriteLine("1) Vous dirigez vers la fontaine");
                                Console.WriteLine("2) Utiliser le produit nettoyant sur la table");
                                Console.WriteLine("3) Essayer d'ouvrir la porte");
                                Console.WriteLine("4) Revenir dans la salle prédecante...");
                                int J = Convert.ToInt32(Console.ReadLine());
                                if (J == 0 || J >= 5)
                                {
                                    Console.WriteLine("Sélectionner une option valide");
                                }
                                if (J == 1)
                                {

                                    Console.WriteLine("Vous approcher de la fontaine...");
                                    if (Bucketisfound == 0)
                                    {
                                        Console.WriteLine("Vous savez pas trop quoi faire alors vous revenez sur vos pas...");
                                    }
                                    if (Bucketisfound == 1)
                                    { 
                                        if (az >= 1)
                                        {
                                            Console.WriteLine("Vous avez déjà remplis votre sceau, alors il n'as pus rien à faire...");
                                            continue;
                                        }
                                        if (Bucketisfound == 1 && az == 0)
                                        {
                                            Console.WriteLine("Vous remplisez votre sceau d'eau");
                                            bucketisfilled = 1;
                                            az++;
                                        }
                                    }

                                }
                                if (J == 2)
                                {
                                    if (bucketisfilled == 1 && ab == 0)
                                    {
                                        Console.WriteLine("Vous remplissez votre sceau de produit nettoyant...");
                                        Console.WriteLine("Mais alors que vous vous déplacer, vous vous enfarger sur la plancher et le contenu du sceau se retrouve par terre!");
                                        Console.WriteLine("Vous remarquer une clé, qui est 100% clean maintenant, comme c'est convénient!");
                                        truekeyisfound = 1;
                                        ab++;

                                    }
                                    if (ab >= 1)
                                    { Console.WriteLine("Vous avez déjà la clé...Pourquoi vouloir utiliser plus de produit?"); }

                                    if (bucketisfilled == 0 && Bucketisfound == 1)
                                    {
                                        Console.WriteLine("...Vous voulez utiliser le produit sans eau? Remplissez-le d'eau avant...");
                                    }
                                    if (Bucketisfound == 0) 
                                    {
                                        Console.WriteLine("...Vous avez aucun contenu pour  contenir le produit et vous n'allez pas vous  dérouiller les mains...");
                                    }
                                }
                                if (J == 3)
                                {
                                    Console.WriteLine("Vous essayer d'ouvrir la porte");
                                    if (truekeyisfound == 0)
                                    {
                                        Console.WriteLine("Vous voulez ouvrir la porte...Mais avec quelle clé?");
                                    }
                                    if (truekeyisfound == 1)
                                    {
                                        Console.WriteLine("Vous entrer la clé dans la porte...Et elle marche!");
                                        Console.WriteLine("Vous ouvrer la porte...Est vous vous échaper!");
                                        Console.WriteLine("Bravo! Vous avez gagner!");
                                        Console.WriteLine("....");
                                        Console.WriteLine("Si vous vouliez un jeu plus lont et fourni...Vous avez jouer au mauvais jeu...");
                                        Console.WriteLine("On vous remboursera pas alors ça sert à rien de nous envoyer des e-mails :) ...");
                                        Console.WriteLine("Fin?");
                                        break;
                                    }
                                }
                                if (J == 4)
                                {
                                    I--;
                                    D--;
                                }


                           }
                        }
                    }
                }
            }
        }


    }
}
