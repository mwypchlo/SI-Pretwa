namespace Pretwa.Logic

type public Player =
    | Blue
    | Red

type public FieldState =
    | Color of Player
    | Empty

type public NextMove =
    | Color of Player