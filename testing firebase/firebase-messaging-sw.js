importScripts("https://www.gstatic.com/firebasejs/8.5.0/firebase-app.js");
importScripts(
    "https://www.gstatic.com/firebasejs/8.5.0/firebase-analytics.js",
);
// For an optimal experience using Cloud Messaging, also add the Firebase SDK for Analytics.
importScripts(
    "https://www.gstatic.com/firebasejs/8.5.0/firebase-messaging.js",
);

// Initialize the Firebase app in the service worker by passing in the
// messagingSenderId.
firebase.initializeApp({
    'messagingSenderId': '959675561431',
    'apiKey': 'AIzaSyBoOxJVUoGbAsM4zBgazxjzM7MeS4IHEzU',
    'projectId': 'testing-6051d',
    'appId': '1:959675561431:web:62ccd9f4f6654d388a8792',
});

// Retrieve an instance of Firebase Messaging so that it can handle background
// messages.
const messaging = firebase.messaging();

messaging.setBackgroundMessageHandler(function (payload) {
    console.log(
        "[firebase-messaging-sw.js] Received background message ",
        payload,
    );
    // Customize notification here
    const notificationTitle = "Background Message Title";
    const notificationOptions = {
        body: "Background Message body.",
        icon: "/itwonders-web-logo.png",
    };

    return self.registration.showNotification(
        notificationTitle,
        notificationOptions,
    );
});