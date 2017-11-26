//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PickedUpComponent pickedUp { get { return (PickedUpComponent)GetComponent(GameComponentsLookup.PickedUp); } }
    public bool hasPickedUp { get { return HasComponent(GameComponentsLookup.PickedUp); } }

    public void AddPickedUp(float newInitialTime, UnityEngine.Vector3 newInitialPosition, float newTotalTravelDistance) {
        var index = GameComponentsLookup.PickedUp;
        var component = CreateComponent<PickedUpComponent>(index);
        component.InitialTime = newInitialTime;
        component.InitialPosition = newInitialPosition;
        component.TotalTravelDistance = newTotalTravelDistance;
        AddComponent(index, component);
    }

    public void ReplacePickedUp(float newInitialTime, UnityEngine.Vector3 newInitialPosition, float newTotalTravelDistance) {
        var index = GameComponentsLookup.PickedUp;
        var component = CreateComponent<PickedUpComponent>(index);
        component.InitialTime = newInitialTime;
        component.InitialPosition = newInitialPosition;
        component.TotalTravelDistance = newTotalTravelDistance;
        ReplaceComponent(index, component);
    }

    public void RemovePickedUp() {
        RemoveComponent(GameComponentsLookup.PickedUp);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPickedUp;

    public static Entitas.IMatcher<GameEntity> PickedUp {
        get {
            if (_matcherPickedUp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PickedUp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPickedUp = matcher;
            }

            return _matcherPickedUp;
        }
    }
}
