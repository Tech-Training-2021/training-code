## [TypeScript](https://www.typescriptlang.org/docs/handbook/intro.html)
### Why TypesScript?
- JavaScript was introduced as a language for the client side. The development of Node.js has marked JavaScript as an emerging server-side technology too. However, as JavaScript code grows, it tends to get messier, making it difficult to maintain and reuse the code. Moreover, its failure to embrace the features of Object Orientation, strong type checking and compile-time error checks prevents
### What is TypeScript?
- TypeScript is an open-source language which builds on JavaScript, one of the world’s most used tools, by adding static type definitions.
- All valid JavaScript code is also TypeScript code. You might get type-checking errors, but that won't stop you from running the resulting JavaScript. While you can go for stricter behavior, that means you're still in control.
- TypeScript code is transformed into JavaScript code via the TypeScript compiler or Babel. This JavaScript is clean, simple code which runs anywhere JavaScript runs: In a browser, on Node.JS or in your apps.
### Installing TypeScript
- Via npm (the Node.js package manager)
  - `npm install -g typescript`
  - Check version of npm `npm -v`
  - Check version of TS compiler `tsc -v`

### [Webpack](https://webpack.js.org/concepts/)
- Webpack is a static module bundler for mordern JavaScript application. 
- Install web pack in 2 settings:
  - `--save`: belongs to production mode
  - `--save-dev`: belongs to developmment

### Angular
- Development framework to create Single-Page Applications.
- AngularJs (2010) - 1.x
- Angular 2 + (2016) - Angular
  
#### Components
- Allow you to create and manage SPA with organization addressing the separation of concerns.
- A component holds data, template, logic for that component.
  - Create a component 
  - Register the component in the module
  - Add a template to it
  - or 
  - `ng g c <component-name>`

#### Directives
- Classes that add additional behaviour to the elements in your Ng App.
  - **Attribute Directives** - change the appearance or behavior of an element, component or another directive. Broadly speaking this changes the attribute behavior in the DOM.
    - Eg: NgModel, NgStyle, NgClass
  - **Structural Directives** - they chages the DOM layout by adding or removing DOM elements
    - Eg: NgIf, NgFor, NgSwitch
#### Dynamic Components
- They are re-usable components.
- To pass data from parent to child component we use `@Input()` directive.
- To pass data from child to parent component we use `@Output()` directive.
#### Templates
- What is rendered on the browser.
- Templates can be :
  - **Internal**: Inline templates within your `component.ts`
  - **External**: Developer have to use `templateUrl` as property to referene the external `component.html file`.    
- **Styles**:
  - **Style URLs property**: is a property inside `@Component` decorator`, which is used to reference local style style sheet (external).
  - **Style property**: which is like inline style within a `component.ts` file.
  - **Within in the template**: By using the `<Style></style`> tag
  - Or all of above
  - Precedance of styles applied **Template > Inline Style > External style**
  - Styles are applied per component level and the CSS isn't leaked because of Angular ability to use **Shadow DOM**.
    - Shadow DOM is a specificatin thagt enables DOM tree and Styles to be encapsulation or it allows developers to apply styles to elements without beeding styles out to the outer world.
- **Types of Bindings**
  - String Interpolation - `{{}}`
  - Property Binding - `[]=value`
    - Property binding is a 1 way binding from component class to template (view)
  - Attribute Binding -`[attr.propertyname]=value`
  - Class Binding -`[class.active]="isActive"`
  - Style Binding - ` [style.backgroundColor]="isActive?'green':'red'"`
  - Event Binding - `(<eventname>)="<event handler>"`
  - Two-way Binding -`[(ngModel)]=<model/object>`

#### Pipes
- They are used to format the values in the template.
  - Uppercase
  - Lowercase
  - Decimal
  - Percentage
  - Currency
#### Directives
- used to manupulate the DOM, add an element, remove and element, update an element to DOM
- *ngFor
  
#### Services
- This is a class which we use to write logic to get data from server.
- Its easy to unit test  component and service by using fake.
- It allows de-coupling between service and a component via **Dependency Injection**.
- `ng g s <service-name>`
  
### References
- [Docs for TS](https://www.typescriptlang.org/docs/handbook)
- [Video Series for TS](https://www.youtube.com/watch?v=2pZmKW9-I_k&list=PL4cUxeGkcC9gUgr39Q_yD6v-bSyMwKPUI)
- [Angular](https://angular.io/docs)
- [Practise without setup](https://angular.io/tutorial)
- [webpack](https://www.youtube.com/watch?v=czW2dJ_pv2g)
- [source-code for webpack](https://github.com/rapidevelop/ex_webpack5)