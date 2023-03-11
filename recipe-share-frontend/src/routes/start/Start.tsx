import { NavLink } from "react-router-dom";
import Login from "../auth/Login";

type Props = {};

const Start = (props: Props) => {
  return (
    <div>
      <h1> Recipe Finder </h1>
      <div>
        Welcome to Recipe finder! Your go to place to find recipies on the world
        wide web!
      </div>

      <div style={{marginTop: 10}}>
        <Login />
      </div>
    </div>
  );
};

export default Start;
