# recipe-share

A recipe sharing platform where users can browse and search for recipes, create and edit their own recipes, and save their favorite recipes. The platform will consist of a React frontend, a GraphQL backend with a C#/.NET server, and a database hosted on AWS Aurora DB.

Here's the project structure:

Frontend:

    Use React and Apollo Client to build the frontend
    Create a homepage where users can browse popular recipes and search for recipes by name or ingredient
    Create a recipe page where users can view recipe details and save recipes to their favorites list
    Create a profile page where users can view and edit their own recipes and their favorites list

Backend:

    Use GraphQL with a C#/.NET server to build the backend
    Implement a schema for the recipe data, including fields for name, ingredients, instructions, and author
    Implement resolvers for fetching, creating, updating, and deleting recipes
    Implement resolvers for fetching and updating user data, including their favorites list

Database:

    Use AWS Aurora DB to host the recipe and user data
    Create a table for the recipe data, including columns for name, ingredients, instructions, and author
    Create a table for the user data, including columns for username, email, password, and favorites list

AWS:

    Use AWS API Gateway to manage the API endpoints for the backend
    Use AWS Lambda to host the backend code
    Use AWS RDS to host the database
