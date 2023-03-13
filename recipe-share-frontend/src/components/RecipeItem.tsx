import { Recipe } from "../types/model";

type Props = Recipe;

const RecipeItem = (props: Props) => (
  <div key={props.id}>
    <h2> {props.title} </h2>
    <span> By: {props.author.name} </span>
    <div> <p>{props.description}</p> </div>
  </div>
);

export default RecipeItem;
