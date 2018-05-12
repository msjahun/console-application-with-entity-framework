using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    
    class Program
    {
      



        static void Main(string[] args)
        {
         void createRecord(String newRecName)
            {
                using (testDbEntities context = new testDbEntities())
                {
                    Recipe recipe = new Recipe
                    {
                      Name = newRecName
                    };

                   context.Recipes.Add(recipe);
                    context.SaveChanges();
                }
           }

                void readRecord(int recordId)
            {
                using (testDbEntities context = new testDbEntities())
                {
                    Recipe recipe = context.Recipes.FirstOrDefault(r => r.Id == recordId);
                   if( !recipe.Equals(null))
                    Console.WriteLine(recipe.Name);
                }
            }

                void updateRecord(String recordName, int recordId)
                {
                    using (testDbEntities context = new testDbEntities())
                    {
                        Recipe recipe = context.Recipes.FirstOrDefault(r => r.Id == recordId);
                    if (!recipe.Equals(null)) { 
                        recipe.Name = recordName;
                        context.SaveChanges();
                    }

                }
                }

                    void deleteRecord(int recordId)
                    {
                        using (testDbEntities context = new testDbEntities())
                        {

                    Recipe recipe = context.Recipes.FirstOrDefault(r => r.Id == recordId);
                    if (!recipe.Equals(null))
                    {
                        context.Recipes.Remove(recipe);
                        context.SaveChanges();
                    }
                        }
                    }



            Console.WriteLine("Program initiated");

            createRecord("Chicken Sautee");
            createRecord("Beef Sautee");
            createRecord("Pinnaple wJuice");
            createRecord("Chicken werSausdftee");
            createRecord("Beef Sawerutesdfe");
            createRecord("Pinnaple sdfJuice");
            createRecord("Chicken Ssdfautee");
            createRecord("Beewref Sautee");
            createRecord("Pinnweraple Juice");

            readRecord(2);
            readRecord(3);
            readRecord(4);
            readRecord(5);
            readRecord(6);
            readRecord(7);
            readRecord(8);

            updateRecord("Musa sause", 4);
            updateRecord("Musa sautee", 5);


            readRecord(2);
            readRecord(3);
            readRecord(4);
            readRecord(5);
            readRecord(6);
            readRecord(7);
            readRecord(8);


            deleteRecord(3);
            deleteRecord(4);
            deleteRecord(5);




            readRecord(2);
            readRecord(3);
            readRecord(4);
            readRecord(5);
            readRecord(6);
            readRecord(7);
            readRecord(8);

            Console.ReadLine();


        }

    }

   
}
