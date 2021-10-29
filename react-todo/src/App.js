import React, { useState } from 'react';
import './App.css';
import Controllers from './Components/Controllers';
import Header from './Components/Header';
import List from './Components/List';
import carpiEmoji from './images/carpiEmoji.png';
import tikEmoji from './images/tikEmoji.png';


function App() {
  const [inputValue,setInputValue]=useState("");
  const [todos,setTodos]=useState([]);

  return (
  <div>
  <Header /> 
  <Controllers inputValue={inputValue} setInputValue={setInputValue}
  buttonClick={()=> {
    const newTodo={
      text:inputValue, status:"active",date:new Date()
    };
    setTodos([...todos,newTodo])
  }}
  /> 

  <List todos={todos} 
  allDeleteClick={()=>{
    setTodos([])/*bütün listeyi sil*/ 
  }}

  removeItem={(index) =>{
    const todos = this.state.todos.filter((todos, todoIndex) => {
      return todoIndex !== index
    })
    this.setState({ todos })
  }}

  
  />
 

  </div>
  );

   
}

export default App;
