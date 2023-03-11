import { SubmitHandler, useForm } from "react-hook-form";
import { NavLink } from "react-router-dom";
import "./style.css";
type Props = {};

interface ILoginInput {
  username: string;
  password: string;
}

const Login = (props: Props) => {
  const { register, handleSubmit } = useForm<ILoginInput>();
  const onSubmit: SubmitHandler<ILoginInput> = (data) => console.log(data);
  return (
    <form onSubmit={handleSubmit(onSubmit)}>
      <div className="login-container">
        <div className="login-input-container">
          <span> Username</span>
          <input
            {...(register("username"), { required: true, maxLength: 20 })}
          />
        </div>
        <div className="login-input-container">
          <span> Password</span>
          <input
            type="password"
            {...(register("password"), { required: true, maxLength: 20 })}
          />
        </div>
        <button type="submit"> Login </button>
        <NavLink to="/signup"> New to Recipe Finder? </NavLink>
      </div>
    </form>
  );
};

export default Login;
