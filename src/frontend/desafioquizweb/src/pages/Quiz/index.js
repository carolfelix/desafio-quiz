import React, { useState, useEffect } from 'react';

import api from '../../services/api.services';

import './style.css';

export default function Quiz() {
  
    const [question, setQuestions] = useState([])

    useEffect(() =>{

        async function loadQuestions(){
            let response = await api.get('/quiz/get-questions')
            setQuestions(response.data)
        }

        loadQuestions();

    }, [])

    return (
        <>
            <div className="container">
                teste
                    <ul>
                        {
                            (question || []).map((question) => (
                                <li key={question.id}>
                                    <div>
                                        <p>{question.description}</p>
                                    </div>
                                </li>
                            ))
                        }
                    </ul>
                </div>
        </>
    )
}