using Raylib_cs;
using chefLegends;

namespace ChefLegends;

class Game
{
    public static void Main()
    {
        initWindow init = new initWindow();
        Raylib.InitWindow(800, 600, "Game");
        Raylib.SetTargetFPS(60);
        Pizza pizza = new Pizza(0,0,0,0.0f);
        bool isStarted = init.startCollision;
        secondMenu menu = new secondMenu();

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            if (!init.startCollision)
            {
                init.Update();
                init.Draw();
            }else
            {
                init.Delete();
                menu.drawButtons();
                menu.drawPizza();
                menu.drawBurger();
            }

            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}
