
export interface Author {
  name: string
  id: string
}

export interface Recipe {
  id: string
  title: string
  author: Author 
  description?: string
  ingredients: Ingredient[]
  steps: string[]
}

export interface Ingredient {
  id: string
  name: string
  unit?: "ml" | "dl" | "l"
}
