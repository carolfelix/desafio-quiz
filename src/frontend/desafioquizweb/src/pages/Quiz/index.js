import React, { useState, useEffect } from 'react';

import api from '../../services/api.services';

import './style.css';

export default function Quiz() {

    const [questions, setQuestions] = useState([])
    let countAnswerCorrect = 0;



    useEffect(() => {

        async function loadQuestions() {
            let response = await api.get('/quiz/get-questions')
            setQuestions(response.data)
        }

        loadQuestions();

    }, [])


    function handleSubmit() {

        var inputElements = document.querySelectorAll('input[type="radio"]');

        for (var i = 0; inputElements[i]; ++i) {
            if (inputElements[i].checked) {
                verifyReplieSelected(inputElements[i].value)
            }
        }

        alert(`vc acertou ${countAnswerCorrect} perguntas`)
    }

    function verifyReplieSelected(idReplie) {

        let questionsList = [...questions]

        questionsList.forEach(element => {

            let repliesList = element.listReplies

            repliesList.forEach(replie => {
                if (replie.id == idReplie && replie.answerCorrect) {
                    countAnswerCorrect++
                }
            });
        });
    }



    return (
        <>
            <div className="container">
                <div className="questions">
                    <h2>Quiz conhecimentos gerais</h2>
                    {
                        (questions || []).map((question) => (
                            <ul key={question.id}>
                                <p>{question.id} - {question.description}</p>
                                {
                                    (question.listReplies || []).map((replies) => (
                                        <li key={replies.id} className="replies">
                                            <div>
                                                <input type="radio" value={replies.id} name={'replies-' + question.id} />
                                                {replies.description}
                                            </div>
                                        </li>
                                    ))
                                }

                            </ul>

                        ))
                    }
                    <div>
                        <button onClick={handleSubmit}>Enviar</button>
                    </div>
                </div>
            </div>
        </>
    )
}