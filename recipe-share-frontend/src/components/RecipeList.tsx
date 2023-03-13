import { useQuery } from "@apollo/client";
import { GET_RECIPES } from "../data/queries/queries";
import RecipeItem from "../components/RecipeItem";
import { Recipe } from "../types/model";

const RecipeList = () => {
  const { loading, error, data } = useQuery<{ recipes: Recipe[] }>(GET_RECIPES);
  if (loading) return <p> Loading... </p>;
  if (error) return <p> Error! {error.message} </p>;

  console.log(data);
  return (
    <div>
      {data && data.recipes.map((r) => <RecipeItem key={r.id} {...r} />)}
    </div>
  );
};

export default RecipeList;
