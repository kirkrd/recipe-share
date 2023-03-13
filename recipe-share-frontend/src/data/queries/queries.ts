import { gql } from "@apollo/client/core";

const GET_RECIPES = gql`
  query GetRecipes {
    recipes {
      id
      title
      description
      author {
        name
      }
    }
  }
`;

export { GET_RECIPES };
