using System.Collections.Generic;
using Unit05.Game.Casting;


namespace Unit05.Game.Scripting
{
    // TODO: Implement the MoveActorsAction class here
    public class MoveActorsAction : Action{
        
        public MoveActorsAction(){

        }
    /// <para>An update action that moves all the actors.</para>
    /// <para>
    /// The responsibility of MoveActorsAction is to move all the actors.
    /// </para>
        public void Execute(Cast cast, Script script)
        {
            List <Actor> actors = cast.GetAllActors();
            foreach(Actor actor in actors)
            {
                actor.MoveNext();
            }
        }
    }


    // 3) Override the Execute(Cast cast, Script script) method. Use the following 
    //    method comment. You custom implementation should do the following:
    //    a) get all the actors from the cast
    //    b) loop through all the actors
    //    c) call the MoveNext() method on each actor.

}