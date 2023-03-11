import { createBrowserRouter } from "react-router-dom";
import App from "../App";
import Signup from "./auth/Signup";
import Start from "./start/Start";

const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      {
        path: "/",
        element: <Start />,
      },
      {
        path: "/signup",
        element: <Signup />,
      },
      {
        path: "/search",
        element: <div> Search </div>,
      },
    ],
  },
]);

export default router;
