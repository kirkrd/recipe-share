import RecipeList from "../../components/RecipeList";

const Start = () => {
  return (
    <div>
      <h1> Recipe Finder </h1>
      <div>
        Welcome to Recipe finder! Your go to place to find recipies on the world
        wide web!
      </div>
      <div style={{ marginTop: 10 }}>
        <input />
        <RecipeList />
      </div>
    </div>
  );
};

export default Start;
