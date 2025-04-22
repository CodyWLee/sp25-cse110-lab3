.item-a {
  grid-area: jesse;
}
.item-b {
  grid-area: james;
}
.item-c {
  grid-area: meowth;
}

.container {
  display: grid;
  grid-template-columns: 50px 50px 50px 50px;
  grid-template-rows: auto;
  grid-template-areas: 
    "jesse jesse james james"
    "jesse meowth meowth james"
    "jesse meowth meowth james"
}
