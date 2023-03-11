import { useForm } from "react-hook-form";

type Props = {};

const Signup = (props: Props) => {
  const { register, handleSubmit } = useForm();
  return (
    <div>
      <h2> Signup </h2>
    </div>
  );
};

export default Signup;
