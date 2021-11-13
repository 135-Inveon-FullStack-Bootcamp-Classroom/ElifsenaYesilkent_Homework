import React, { useState } from 'react';
import './App.css';
import Controllers from './Components/Controllers';
import Header from './Components/Header';
import TodoList from './Components/TodoList';



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

  <TodoList todos={todos}  
  allDeleteClick={()=>{
    setTodos([])/*bütün listeyi sil*/ 
  }}

  buttonDelete={(index)=>{
    const newTodos = [...todos];
    newTodos.splice(index, 1);
    setTodos(newTodos);//seçili maddeyi sil
  }}
  />

  </div>
  );
}

export default App;
