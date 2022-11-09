:-discontiguous(prescription/3).
:-discontiguous(ingredients/4).
:-discontiguous(type/3).

% Base

% prescription('Savory pancakes with fried egg',150,'').

% ingredients('Protein pancakes',40,'g.','Savory pancakes with fried egg').

% type('Savory pancakes with fried egg','breakfast','lower').

% Breakfasts

prescription("Baked oatmeal",58.75,"").

ingredients("Oatmeal",45,"g","Baked oatmeal").
ingredients("Hot water",50,"ml","Baked oatmeal").
ingredients("Cinnamon",0.25,"cdta.","Baked oatmeal").
ingredients("Egg whites",0.5,"pz","Baked oatmeal").
ingredients("Almond milk",50,"ml","Baked oatmeal").
ingredients("Grated apple",37.5,"g","Baked oatmeal").

type("Baked oatmeal","Breakfast","Lower").

prescription("Cloud bread",16,"").

ingredients("Egg",0.5,"pz","Cloud bread").
ingredients("Double cream cheese",16.67,"g","Cloud bread").
ingredients("Baking Protein",0.17,"tbsp.","Cloud bread").
ingredients("Salt",0.17,"pinch","Cloud bread").

type("Cloud bread","Breakfast","Lower").

prescription("Benedict eggs",314,"").

ingredients("Yema",1,"pz","Benedict eggs").
ingredients("Lemon juice",1,"squirt","Benedict eggs").
ingredients("Greek yogurt",50,"g","Benedict eggs").
ingredients("Mustard",1,"tsp.","Benedict eggs").
ingredients("Egg",1,"pz","Benedict eggs").
ingredients("Wine vinegar",1,"tbsp.","Benedict eggs").
ingredients("Bacon",2,"slices","Benedict eggs").
ingredients("Bread",1,"slice","Benedict eggs").
ingredients("Salt",1,"pinch","Benedict eggs").
ingredients("Pepper",1,"pinch","Benedict eggs").

type("Benedict eggs","Breakfast","Lower").

prescription("Savory pancakes with fried egg",150,"").

ingredients("Pancakes",10,"g","Savory pancakes with fried egg").
ingredients("Water",115,"ml","Savory pancakes with fried egg").
ingredients("Coconut oil",5,"g","Savory pancakes with fried egg").
ingredients("Egg",1,"pz","Savory pancakes with fried egg").
ingredients("Chicken breast",1,"slice","Savory pancakes with fried egg").
ingredients("Salt",1,"pinch","Savory pancakes with fried egg").

type("Savory pancakes with fried egg","Breakfast","Lower").

prescription("Salmon and fresh cheese rolls",564,"").

ingredients("Pancakes",80,"g","Salmon and fresh cheese rolls").
ingredients("Water",200,"ml","Salmon and fresh cheese rolls").
ingredients("Fresh cheese",100,"g","Salmon and fresh cheese rolls").
ingredients("Smoked salmon",80,"g","Salmon and fresh cheese rolls").
ingredients("Rucola",1,"bunch","Salmon and fresh cheese rolls").
ingredients("Salt",1,"pinch","Salmon and fresh cheese rolls").
ingredients("Pepper",2,"pinch","Salmon and fresh cheese rolls").

type("Salmon and fresh cheese rolls","Breakfast","Keep").

prescription("Bread with olives and dried tomato",1044,"").

ingredients("Pan",1,"paquete","Bread with olives and dried tomato").
ingredients("Agua",230,"ml","Bread with olives and dried tomato").
ingredients("Aceitunas",100,"g","Bread with olives and dried tomato").
ingredients("Tomates deshidratados",40,"g","Bread with olives and dried tomato").
ingredients("Oregano seco",1,"cdta.","Bread with olives and dried tomato").

type("Bread with olives and dried tomato","Breakfast","Keep").

prescription("Bread with figs and nuts",1068,"").

ingredients("Pan",1,"paquete","Bread with figs and nuts").
ingredients("Agua",230,"ml","Bread with figs and nuts").
ingredients("Higos deshidratados",80,"g","Bread with figs and nuts").
ingredients("Nueces",40,"g","Bread with figs and nuts").

type("Bread with figs and nuts","Breakfast","Keep").

prescription("Apple pancake",513,"").

ingredients("Apple",1,"pz","Apple pancake").
ingredients("Egg",2,"pz","Apple pancake").
ingredients("Apricot jam",60,"g","Apple pancake").
ingredients("Vegetable oil",1,"little","Apple pancake").

type("Apple pancake","Breakfast","Keep").

prescription("Cream filled pancakes",150,"").

ingredients("Pancakes",40,"g","Cream filled pancakes").
ingredients("Water",65,"ml","Cream filled pancakes").
ingredients("Cream",20,"g","Cream filled pancakes").
ingredients("Coconut oil",5,"g","Cream filled pancakes").

type("Cream filled pancakes","Breakfast","Rise").

prescription("Pancakes with kimchi",510,"").

ingredients("Pancakes",80,"g","Pancakes with kimchi").
ingredients("Cold water",180,"ml","Pancakes with kimchi").
ingredients("Vegetarian kimchi",150,"g","Pancakes with kimchi").
ingredients("Coconut oil",15,"g","Pancakes with kimchi").
type("Pancakes with kimchi","Breakfast","Rise").

% Lunches

prescription("Vegan pasta with red radicchio and walnuts",271.5,"").

ingredients("Pasta",100,"g","Vegan pasta with red radicchio and walnuts").
ingredients("Red radicchio",75,"g","Vegan pasta with red radicchio and walnuts").
ingredients("Onion",0.25,"pz","Vegan pasta with red radicchio and walnuts").
ingredients("Olive oil",0.5,"tbsp.","Vegan pasta with red radicchio and walnuts").
ingredients("Cream of oatmeal",50,"ml","Vegan pasta with red radicchio and walnuts").
ingredients("Nuts",5,"g","Vegan pasta with red radicchio and walnuts").
ingredients("Sal",1,"pinch","Vegan pasta with red radicchio and walnuts").
ingredients("Pepper",1,"pinch","Vegan pasta with red radicchio and walnuts").
type("Vegan pasta with red radicchio and walnuts","Lunch","Lower").

prescription("Beet burgers",19.5,"").

ingredients("Fresh beets",20,"g","Beet burgers").
ingredients("Small onion",0.17,"kg","Beet burgers").
ingredients("Garlic clove",1,"pz","Beet burgers").
ingredients("Beans",45,"g","Beet burgers").
ingredients("Soy sauce",0.33,"tablespoon","Beet burgers").
ingredients("Tahin",0.17,"tablespoon","Beet burgers").
ingredients("Sal",0.08,"tablespoon","Beet burgers").
ingredients("Pepper",0.08,"tablespoon","Beet burgers").
ingredients("Cumin",0.17,"tablespoon","Beet burgers").
ingredients("Parsley",0.08,"bunch","Beet burgers").

type("Beet burgers","Lunch","Lower").

prescription("Pasta with light cream cheese",255.5,"").

ingredients("Pasta",90,"g","Pasta with light cream cheese").
ingredients("Garlic clove",0.5,"pz","Pasta with light cream cheese").
ingredients("Coconut oil",0.5,"tsp.","Pasta with light cream cheese").
ingredients("Flour",0.5,"tsp.","Pasta with light cream cheese").
ingredients("Vegetable broth",50,"ml","Pasta with light cream cheese").
ingredients("Milk",40,"ml","Pasta with light cream cheese").
ingredients("Parmesan cheese",15,"g","Pasta with light cream cheese").

type("Pasta with light cream cheese","Lunch","Lower").

prescription("Green gazpacho",123.5,"").

ingredients("Bread",2,"slices","Green gazpacho").
ingredients("Cucumber",140,"g","Green gazpacho").
ingredients("Green pepper",40,"g","Green gazpacho").
ingredients("Avocado",0.13,"pz","Green gazpacho").
ingredients("White onion",0.13,"pz","Green gazpacho").
ingredients("Garlic clove",0.25,"pz","Green gazpacho").
ingredients("Spinach",15,"g","Green gazpacho").
ingredients("Cold water",100,"ml","Green gazpacho").
ingredients("Vinegar",0.5,"tsp.","Green gazpacho").
ingredients("Olive oil",0.5,"tbsp.","Green gazpacho").
ingredients("Salt",1,"pinch","Green gazpacho").

types("Green gazpacho","Lunch","Lower").

prescription("Kale Pesto Pasta",252,"").

ingredients("Pasta",100,"g","Kale Pesto Pasta").
ingredients("Kale",50,"g","Kale Pesto Pasta").
ingredients("Fresh Parsley",12.5,"g","Kale Pesto Pasta").
ingredients("Nuts",5,"g","Kale Pesto Pasta").
ingredients("Garlic clove",0.5,"pz","Kale Pesto Pasta").
ingredients("Lemon Juice",1,"drizzle","Kale Pesto Pasta").
ingredients("Olive Oil",10,"ml","Kale Pesto Pasta").
ingredients("Water",10,"ml","Kale Pesto Pasta").
ingredients("Sal",1,"pz","Kale Pesto Pasta").
ingredients("Pepper",1,"pz","Kale Pesto Pasta").

type("Kale Pesto Pasta","Lunch","Keep").

prescription("Light beet paste",259,"").

ingredients("Onion",0.25,"pz","Light beet paste").
ingredients("Garlic clove",0.5,"pz","Light beet paste").
ingredients("Beet",75,"g","Light beet paste").
ingredients("Olive oil",0.5,"tbsp.","Light beet paste").
ingredients("Liquid from beet jar",100,"ml","Light beet paste").
ingredients("Vegetable broth",150,"ml","Light beet paste").
ingredients("Paste",100,"g","Light beet paste").
ingredients("Feta cheese",20,"g","Light beet paste").
ingredients("Sal",1,"pinch","Light beet paste").
ingredients("Pepper",1,"pinch","Light beet paste").

type("Light beet paste","Lunch","Keep").

prescription("Gazpacho fitness",122.5,"").

ingredients("Bread",2,"slices","Gazpacho fitness").
ingredients("Bunch tomatoes",165,"g","Gazpacho fitness").
ingredients("Red pepper",40,"g","Gazpacho fitness").
ingredients("Cucumber",65,"g","Gazpacho fitness").
ingredients("White onion",0.13,"pz","Gazpacho fitness").
ingredients("Garlic clove",0.25,"pz","Gazpacho fitness").
ingredients("Cold water",100,"ml","Gazpacho fitness").
ingredients("Vinegar",0.5,"tsp.","Gazpacho fitness").
ingredients("Olive oil",0.5,"tbsp.","Gazpacho fitness").
ingredients("Salt",1,"pinch","Gazpacho fitness").

type("Gazpacho fitness","Lunch","Keep").

prescription("Pasta with basil pesto",387.5,"").

ingredients("Pinions",10,"g","Pasta with basil pesto").
ingredients("Cashews",15,"g","Pasta with basil pesto").
ingredients("Fresh basil",20,"g","Pasta with basil pesto").
ingredients("Garlic clove",0.5,"pz","Pasta with basil pesto").
ingredients("Olive oil",30,"ml","Pasta with basil pesto").
ingredients("Yeast flakes",1,"tbsp.","Pasta with basil pesto").
ingredients("Salt",1,"pinch","Pasta with basil pesto").
ingredients("Pepper",1,"pinch","Pasta with basil pesto").
ingredients("Parmesan",1,"pinch","Pasta with basil pesto").
ingredients("Pasta",100,"g","Pasta with basil pesto").

type("Pasta with basil pesto","Lunch","Rise").

prescription("Vegan carbonara pasta",604,"").

ingredients("Pasta",100,"g","Vegan carbonara pasta").
ingredients("Olive oil",1,"tsp.","Vegan carbonara pasta").
ingredients("Smoked tofu",50,"g","Vegan carbonara pasta").
ingredients("Vegetable cream",100,"ml","Vegan carbonara pasta").
ingredients("Yeast flakes",1,"tbsp.","Vegan carbonara pasta").
ingredients("Salt",1,"pinch","Vegan carbonara pasta").

type("Vegan carbonara pasta","Lunch","Rise").

prescription("Arancini",78,"").

ingredients("Olive oil",0.33,"tbsp.","Arancini").
ingredients("Onion",0.33,"pz","Arancini").
ingredients("Rissotto rice",0.4,"l","Arancini").
ingredients("Dry",16.67,"g","Arancini").
ingredients("Vegetable broth",26.67,"g","Arancini").
ingredients("Grated Parmesan cheese",30,"g","Arancini").
ingredients("Protein flakes",33.33,"g","Arancini").
ingredients("Egg",66.67,"g","Arancini").
ingredients("Salt",1,"pinch","Arancini").
ingredients("Pepper",1,"pinch","Arancini").
ingredients("Olive oil",1,"little","Arancini").

type("Arancini","Lunch","Rise").

% Dinners

type("Kale Pesto Pasta","Dinner","Rise").
type("Cloud bread","Dinner","Lower").
type("Salmon and fresh cheese rolls","Dinner","Lower").

prescription("Blini with salmon",4.58,"").

ingredients("Pancakes",6.67,"g","Blini with salmon").
ingredients("Water",10.83,"g","Blini with salmon").
ingredients("Coconut oil",0.17,"tsp","Blini with salmon").
ingredients("Smoked salmon",8.33,"g","Blini with salmon").
ingredients("Quark cheese",10,"g","Blini with salmon").
ingredients("Salt",1,"Pinch","Blini with salmon").
ingredients("Pepper",1,"Pinch","Blini with salmon").

type("Blini with salmon","Dinner","Rise").

prescription("Vegan cauliflower wings",64.5,"").

ingredients("Cauliflower head",0.25,"Medium","Vegan cauliflower wings").
ingredients("Spelt flour",22.5,"g","Vegan cauliflower wings").
ingredients("Water",31.25,"ml","Vegan cauliflower wings").
ingredients("Oat milk, unsweetened",31.25,"g","Vegan cauliflower wings").
ingredients("Garlic powder",0.5,"tsp","Vegan cauliflower wings").
ingredients("Pimineton",0.5,"tsp","Vegan cauliflower wings").
ingredients("Salt",1,"Pinch","Vegan cauliflower wings").
ingredients("Pepper",1,"Pinch","Vegan cauliflower wings").
ingredients("Protein flakes",25,"g","Vegan cauliflower wings").
ingredients("Barbecue sauce",45,"ml","Vegan cauliflower wings").

type("Vegan cauliflower wings","Dinner","Rise").

prescription("Arugula and parma pizza",682,"").

ingredients("Light pizza dough",100,"g","Arugula and parma pizza").
ingredients("Warm water",100,"ml","Protein arugula and parma pizza").
ingredients("Tomato sauce (chopped tomatoes)",100,"g","Protein arugula and parma pizza").
ingredients("Garlic",60,"g","Arugula and parma pizza").
ingredients("Salt",60,"g","Arugula and parma pizza").
ingredients("Mozzarella",4,"Slices","Arugula and parma pizza").
ingredients("Parma ham",1,"Bunch","Arugula and parma pizza").
ingredients("Arugula (optional)",1,"Bunch","Arugula and parma pizza").

type("Arugula and parma pizza","Dinner","Rise").

prescription("Pasta salad",568,"").

ingredients("Prawn",60,"g","Pasta salad").
ingredients("Onion",0.5,"g","Pasta salad").
ingredients("Zucchini",1,"tbsp","Pasta salad").
ingredients("Pasta",100,"g","Pasta salad").
ingredients("Olive oil",10,"ml","Pasta salad").
ingredients("Salt",1,"Pinch","Pasta salad").
ingredients("Pepper",1,"Pinch","Pasta salad").

type("Pasta salad","Dinner","Keep").

prescription("Egg white bread",107,"").

ingredients("Ground almonds",100,"g","Egg white bread").
ingredients("Crushed flax seeds",50,"g","Egg white bread").
ingredients("Wheat bran",50,"g","Egg white bread").
ingredients("Whey protein neutral flavor",50,"g","Egg white bread").
ingredients("Yeast",15,"g","Egg white bread").
ingredients("Sal",1,"tsp","Egg white bread").
ingredients("Quark low fat",10,"g","Egg white bread").
ingredients("Egg whites",6,"Pzas","Egg white bread").
ingredients("Pumpkin seeds",20,"g","Egg white bread").
ingredients("Flax (or sunflower) seeds",20,"g","Egg white bread").

type("Egg white bread","Dinner","Lower").

prescription("Breaded Cauliflower Steaks",363,"").

ingredients("Cauliflower Head",1,"g","Breaded Cauliflower Steaks").
ingredients("Oat milk",100,"ml","Breaded Cauliflower Steaks").
ingredients("Protein flakes",40,"g","Breaded Cauliflower Steaks").
ingredients("Sal",1,"Tsp","Breaded Cauliflower Steaks").
ingredients("Paprika",1,"Tbsp","Breaded Cauliflower Steaks").
ingredients("Curry powder",0.5,"Tbsp","Breaded Cauliflower Steaks").
ingredients("Garlic powder",2,"Tbsp","Breaded Cauliflower Steaks").

type("Breaded Cauliflower Steaks","Dinner","Keep").

% Salads

prescription("Asian salad with cauliflower and fennel",97.67,"").

ingredients("Medium cauliflower",0.33,"g","Asian salad with cauliflower and fennel").
ingredients("fennel in small bulb",0.33,"g","Asian salad with cauliflower and fennel").
ingredients("Coconut oil",0.33,"cda","Asian salad with cauliflower and fennel").
ingredients("Lime",0.33,"ml","Asian salad with cauliflower and fennel").
ingredients("Fresh ginger",0.33,"Chunk","Asian salad with cauliflower and fennel").
ingredients("Soy sauce",1,"Tbsp","Asian salad with cauliflower and fennel").
ingredients("Rice vinegar",0.67,"Cdas","Asian salad with cauliflower and fennel").
ingredients("Agave syrup",0.33,"Cdas","Asian salad with cauliflower and fennel").
ingredients("Sesame oil",0.33,"Tbsp","Asian salad with cauliflower and fennel").
ingredients("Lombard",23.33,"g","Asian salad with cauliflower and fennel").
ingredients("Chives",0.67,"g","Asian salad with cauliflower and fennel").
ingredients("Cashews",10,"g","Asian salad with cauliflower and fennel").
ingredients("Coconut chips",6.67,"g","Asian salad with cauliflower and fennel").
ingredients("Sal",1,"Pinch","Asian salad with cauliflower and fennel").
ingredients("Pepper",1,"Pinch","Chilli","Asian salad with cauliflower and fennel").

type("Asian salad with cauliflower and fennel","Salad","Lower").

prescription("Salad with chicken breast or tofu",81,"").

ingredients("Lettuce (to taste)",1,"Pza","Salad with chicken breast or tofu").
ingredients("Chicken breast",200,"g","Salad with chicken breast or tofu").
ingredients("Smoked Tofu",125,"g","Salad with chicken breast or tofu").
ingredients("Raw vegetables to taste",200,"g","Salad with chicken breast or tofu").
ingredients("Pimiento",1,"Tsp","Salad with chicken breast or tofu").
ingredients("Tomato",1,"Pza","Salad with chicken breast or tofu").
ingredients("Organic coconut oil",1,"Diente","Salad with chicken breast or tofu").
ingredients("For the sauce",2,"Tbsp","Salad with chicken breast or tofu").
ingredients("Garlic",1,"Tbsp","Salad with chicken breast or tofu").
ingredients("Yogurt",1,"Pinch","Salad with chicken breast or tofu").
ingredients("Balsamic vinegar",1,"Pinch","Salad with chicken breast or tofu").
ingredients("Sal",1,"Pizca","Salad with chicken breast or tofu").
ingredients("Pimineta",1,"Pizca","Salad with chicken breast or tofu").

type("Salad with chicken breast or tofu","Salad","Lower").

prescription("Lamb's lettuce salad with sautéed sweet potato",694,"").

ingredients("Batata",200,"g","Lamb's lettuce salad with sautéed sweet potato").
ingredients("Cherry tomatoes",100,"g","Lamb's lettuce salad with sautéed sweet potato").
ingredients("Organic coconut oil",1,"Tbsp","Lamb's lettuce salad with sautéed sweet potato").
ingredients("Olive oil",1,"Tbsp","Lamb's lettuce salad with sautéed sweet potato").
ingredients("Balsamic vinegar",1,"Tbsp","Lamb's lettuce salad with sautéed sweet potato").
ingredients("Sal",1,"Pizca","Lamb's lettuce salad with sautéed sweet potato").
ingredients("Pepper",1,"Pinch","Lamb's lettuce salad with sautéed sweet potato").
ingredients("Pumpkin seeds",20,"g","Lamb's lettuce salad with sautéed sweet potato").

type("Lamb's lettuce salad with sautéed sweet potato","Salad","Keep").

prescription("Salad of asparagus with strawberries and feta cheese",76.25,"").

ingredients("green asparagus",62.5,"g","Salad of asparagus with strawberries and feta cheese").
ingredients("Rucula",20,"g","Salad of asparagus with strawberries and feta cheese").
ingredients("Feta cheese",25,"g","Salad of asparagus with strawberries and feta cheese").
ingredients("Strawberries",50,"g","Salad of asparagus with strawberries and feta cheese").
ingredients("Pinones",7.5,"g","Salad of asparagus with strawberries and feta cheese").
ingredients("White balsamic vinegar",1.5,"tbsp","Salad of asparagus with strawberries and feta cheese").
ingredients("Honey",0.25,"Tbsp","Salad of asparagus with strawberries and feta cheese").
ingredients("Olive oil",1.25,"Tbsp","Salad of asparagus with strawberries and feta cheese").
ingredients("Sal",1,"Pizca","Salad of asparagus with strawberries and feta cheese").
ingredients("Pepper",1,"Pizca","Salad of asparagus with strawberries and feta cheese").

type("Salad of asparagus with strawberries and feta cheese","Salad","Lower").

prescription("Buddha christmas bowl",515,"").

ingredients("Spinach leaves",1,"Bunch","Buddha christmas bowl").
ingredients("Brocoli",100,"g","Buddha christmas bowl").
ingredients("Sugar peas",50,"g","Buddha christmas bowl").
ingredients("Brussels sprouts",80,"g","Buddha christmas bowl").
ingredients("Red cabbage",100,"g","Buddha christmas bowl").
ingredients("Avocado",0.5,"g","Buddha christmas bowl").
ingredients("Rabano",1,"Pza","Buddha christmas bowl").
ingredients("Pomegranate seeds",30,"g","Buddha christmas bowl").
ingredients("Rote Beete Hummus",50,"g","Buddha christmas bowl").
ingredients("Vegan bread",1,"Slice","Buddha christmas bowl").

type("Buddha christmas bowl","Salad","Keep").

prescription("Semolina pudding without sugar",255,"").

ingredients("Almond milk",200,"ml","Semolina pudding without sugar").
ingredients("Water",30,"g","Semolina pudding without sugar").
ingredients("Common wheat semolina",20,"g","Semolina pudding without sugar").
ingredients("Whey protein to choose",80,"g","Semolina pudding without sugar").
ingredients("Cherries (from a jar)",1,"Pinch","Semolina pudding without sugar").

type("Semolina pudding without sugar","Salad","Lower").

prescription("Mixed salad with orange and walnuts",189,"").

ingredients("Chicoria",125,"g","Mixed salad with orange and walnuts").
ingredients("Escarole",75,"g","Mixed salad with orange and walnuts").
ingredients("Orange (medium size)",0.5,"g","Mixed salad with orange and walnuts").
ingredients("Nuts",12.5,"g","Mixed salad with orange and walnuts").
ingredients("Olive oil",1.5,"tbsp","Mixed salad with orange and walnuts").
ingredients("Mustard",1,"Tbsp","Mixed salad with orange and walnuts").
ingredients("Honey",0.5,"Tbsp","Mixed salad with orange and walnuts").
ingredients("Sal",1,"Pizca","Mixed salad with orange and walnuts").
ingredients("Pepper",1,"Pinch","Mixed salad with orange and walnuts").

type("Mixed salad with orange and walnuts","Salad","Keep").

prescription("Superfood Kale Salad",176,"").

ingredients("Kale",100,"g","Superfood Kale Salad").
ingredients("Carrot",50,"g","Superfood Kale Salad").
ingredients("Limes",1,"Pza","Superfood Kale Salad").
ingredients("Honey",0.5,"Tbsp","Superfood Kale Salad").
ingredients("Coconut Oil",1.5,"Tbsp","Superfood Kale Salad").
ingredients("White chia seeds",1,"Tbsp","Superfood Kale Salad").
ingredients("Dried Cranberries",1,"Tbsp","Superfood Kale Salad").

type("Superfood Kale Salad","Salad","Lower").

prescription("Chickpea salad",470,"").

ingredients("Canned Chickpeas",250,"g","Chickpea salad").
ingredients("Cherry tomatoes",5,"g","Chickpea salad").
ingredients("Cucumber",100,"g","Chickpea salad").
ingredients("Olives (green or black)",19,"Pcs","Chickpea salad").
ingredients("Olive oil",1,"Tbsp","Chickpea salad").
ingredients("Apple vinegar",1,"Tbsp","Chickpea salad").
ingredients("Fresh parsley",1,"Bouquet","Chickpea salad").
ingredients("Salt",1,"Pinch","Chickpea salad").
ingredients("Pepper (optional)",1,"Pinch","Chickpea salad").

type("Chickpea salad","Salad","Keep").

prescription("Vegetable bowl with turmeric dressing",458,"").

ingredients("Sweet potato",200,"g","Vegetable bowl with turmeric dressing").
ingredients("Brocoli",100,"g","Vegetable bowl with turmeric dressing").
ingredients("Cherry tomatoes",4,"Pza","Vegetable bowl with turmeric dressing").
ingredients("Radishes",3,"Pza","Vegetable bowl with turmeric dressing").
ingredients("Quinoa",50,"g","Vegetable bowl with turmeric dressing").
ingredients("Garlic clove",1,"Pza","Vegetable bowl with turmeric dressing").
ingredients("Plain yogurt",3,"Tbsp","Vegetable bowl with turmeric dressing").
ingredients("Sal",50,"g","Vegetable bowl with turmeric dressing").
ingredients("Turmeric",0.25,"Tbsp","Vegetable bowl with turmeric dressing").

type("Vegetable bowl with turmeric dressing","Salad","Lower").


%Rules

contains(T,D,R,CS,L,I,C,M):-prescription(R,CS,L),type(R,T,D),ingredients(I,C,M,R).
