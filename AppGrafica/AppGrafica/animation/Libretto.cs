using AppGrafica.extructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica.animation
{
    public class Libretto
    {
        public Dictionary<string, Objeto> objects;
        public List<Action> actions;

        public Libretto(Dictionary<string, Objeto> objects)
        {
            this.objects = objects;
            actions = new List<Action>();
        }

        public void loadActions()
        {
            Action actionAve = Action.DeserializeJsonFile("animateAve.json");
            actions.Add(actionAve);

            Action actionCar = Action.DeserializeJsonFile("animateCar.json");
            actions.Add(actionCar);
        }

        public void execute()
        {
            foreach (var action in actions)
            {
                Objeto objeto = objects[action.name];
                Animation animation = new Animation(100, action.start, action.duration, objeto, action);
                animation.calculateDifferential();
                animation.execute();
            }
        }

    }
}
